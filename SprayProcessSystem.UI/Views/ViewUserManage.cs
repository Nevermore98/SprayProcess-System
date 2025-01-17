using AntdUI;
using Mapster;
using Microsoft.Extensions.DependencyInjection;
using SprayProcessSystem.BLL.Dto.AuthDto;
using SprayProcessSystem.BLL.Dto.UserDto;
using SprayProcessSystem.BLL.Managers;
using SprayProcessSystem.Model;
using SprayProcessSystem.UI.Models;
using SprayProcessSystem.UI.UserControls.Modals;

namespace SprayProcessSystem.UI.Views
{
    public partial class ViewUserManage : UserControl
    {
        private AntList<User> _userList = new();
        private User _currentUser;
        private readonly UserManager _userManager;
        private readonly AuthManager _authManager;
        private int _adminRowIndex;

        public ViewUserManage()
        {
            _userManager = Program.ServiceProvider.GetRequiredService<UserManager>();
            _authManager = Program.ServiceProvider.GetRequiredService<AuthManager>();
            this.Load += ViewUserManage_Load;
            InitializeComponent();
        }

        private async void ViewUserManage_Load(object? sender, EventArgs e)
        {
            InitTableColumns();
            await LoadTableData();

            // 加载权限，设置勾选框
            var queryEngineerAuthResponse = await _authManager.QueryAuthByRoleAsync(new AuthQueryResultDto() { Role = "工程师" });
            if (queryEngineerAuthResponse.Result == Constants.Result.Success)
            {
                var engineerAuthList = queryEngineerAuthResponse.Data[0].AuthList;
                var engineerAuthControlList = Generic.GetChildControls(panel_engineerAuth);
                foreach (var item in engineerAuthControlList)
                {
                    if (item is AntdUI.Checkbox checkbox && checkbox.Enabled)
                    {
                        checkbox.Checked = engineerAuthList.Contains(checkbox.Text);
                    }
                }
            }

            // 操作员
            var queryOperatorAuthResponse = await _authManager.QueryAuthByRoleAsync(new AuthQueryResultDto() { Role = "操作员" });
            if (queryOperatorAuthResponse.Result == Constants.Result.Success)
            {
                var operatorAuthList = queryOperatorAuthResponse.Data[0].AuthList;
                var operatorAuthControlList = Generic.GetChildControls(panel_operatorAuth);
                foreach (var item in operatorAuthControlList)
                {
                    if (item is AntdUI.Checkbox checkbox && checkbox.Enabled)
                    {
                        checkbox.Checked = operatorAuthList.Contains(checkbox.Text);
                    }
                }
            }

            // 访客
            var queryVisitorAuthResponse = await _authManager.QueryAuthByRoleAsync(new AuthQueryResultDto() { Role = "访客" });
            if (queryVisitorAuthResponse.Result == Constants.Result.Success)
            {
                var visitorAuthList = queryVisitorAuthResponse.Data[0].AuthList;
                var visitorAuthControlList = Generic.GetChildControls(panel_visitorAuth);
                foreach (var item in visitorAuthControlList)
                {
                    if (item is AntdUI.Checkbox checkbox && checkbox.Enabled)
                    {
                        checkbox.Checked = visitorAuthList.Contains(checkbox.Text);
                    }
                }
            }
        }

        private void InitTableColumns()
        {
            table_user.RowHeight = 40;
            table_user.Columns = new ColumnCollection() {
                new ColumnCheck("IsSelected"){Fixed = true},
                new Column("UserName", "账号", ColumnAlign.Center)
                {
                    Width="160",
                    SortOrder = true
                },
                new Column("NickName", "昵称", ColumnAlign.Center)
                {
                     Width="160",
                     SortOrder = true
                },
                // Table 修改 RowHeight 行高后，中文无法显示，需要修改表格的 Gap
                new Column("Role", "角色", ColumnAlign.Center),
                new Column("CreatedAt", "创建时间", ColumnAlign.Center){
                    Width = "190",
                    SortOrder = true
                },
                new ColumnSwitch("IsEnabled", "是否启用", ColumnAlign.Center){
                    Call = (value, record, i_row, i_col) => {
                        var user = record as User;
                        var dto = new UserAddUpdateDto() { Id = user.Id, IsEnabled = value };
                        var response =  _userManager.UpdateUserAsync(dto).GetAwaiter().GetResult();
                        var messageType = response.Result == Constants.Result.Success ? TType.Success : TType.Error;
                        Generic.ShowMessage(this.ParentForm, response.Message.ToString(), messageType);

                        return response.Result == Constants.Result.Success ? value : !value;
                    }
                },
                new Column("Action", "操作", ColumnAlign.Center){
                    Width = "120",
                    Render = (value, record, i_row) =>
                    {
                        return new CellButton[] {new ("edit", "编辑", TTypeMini.Primary), new ("delete", "删除", TTypeMini.Error)};
                    },
                }
            };
        }

        private async Task LoadTableData()
        {
            _userList.Clear();
            table_user.SetRowEnable(_adminRowIndex, true, true);
            var queryAllUserResponse = await _userManager.QueryAllUserAsync();
            var userList = queryAllUserResponse.Data;
            _userList.AddRange(userList.Where(x => x.UserName.ToLower() != "dev").Select(x => x.Adapt<User>()).ToArray());

            table_user.Binding(_userList);

            // 禁用默认管理员账号
            _adminRowIndex = _userList.IndexOf(_userList.FirstOrDefault(x => x.UserName.ToLower() == "admin"));
            table_user.SetRowEnable(_adminRowIndex, false, true);
        }

        private async void table_user_CellButtonClick(object sender, TableButtonEventArgs e)
        {
            var buttonText = e.Btn.Text;

            if (e.Record is User user)
            {
                _currentUser = user;
                switch (buttonText)
                {
                    case "编辑":
                        var userAddUpdateDto = user.Adapt<UserAddUpdateDto>();
                        var form = ActivatorUtilities.CreateInstance<ModalUserEdit>(Program.ServiceProvider, this.ParentForm, userAddUpdateDto);
                        form.Size = new Size(300, 350);
                        Generic.ShowModal(this.ParentForm, "编辑用户", form, TType.Info, false);
                        // 提交编辑
                        if (form.IsSubmit)
                        {
                            userAddUpdateDto.UpdatedAt = DateTime.Now;
                            var updateUserResponse = await _userManager.UpdateUserAsync(userAddUpdateDto);

                            var messageType = updateUserResponse.Result == Constants.Result.Success ? TType.Success : TType.Error;
                            Generic.ShowMessage(this.ParentForm, updateUserResponse.Message, messageType);
                            await LoadTableData();
                        }
                        break;
                    case "删除":
                        var modalResult = Generic.ShowModal(this.ParentForm, "删除用户", $"确定要删除用户 {user.UserName} 吗？", TType.Warn);

                        if (modalResult == DialogResult.OK)
                        {
                            var deleteUserResponse = await _userManager.DeleteUserAsync(new UserDeleteDto { Id = user.Id, UserName = user.UserName });
                            if (deleteUserResponse.Result == Constants.Result.Success) await LoadTableData();

                            var messageType = deleteUserResponse.Result == Constants.Result.Success ? TType.Success : TType.Error;
                            Generic.ShowMessage(this.ParentForm, deleteUserResponse.Message, messageType);
                        }
                        break;

                }
            }
        }


        private async void btn_addUser_ClickAsync(object sender, EventArgs e)
        {
            var userAddUpdateDto = new UserAddUpdateDto();

            var form = ActivatorUtilities.CreateInstance<ModalUserEdit>(Program.ServiceProvider, this.ParentForm, userAddUpdateDto, false);
            form.Size = new Size(300, 350);
            AntdUI.Modal.open(new AntdUI.Modal.Config(this.ParentForm, "添加用户", form, TType.Info)
            {
                BtnHeight = 0,
                Keyboard = false,
                Font = new Font(Global.FontCollection.Families[0], 11),
                MaskClosable = true,
            });
            if (form.IsSubmit)
            {
                var addUserResponse = await _userManager.AddUserAsync(userAddUpdateDto);
                if (addUserResponse.Result == Constants.Result.Success)
                {
                    await LoadTableData();
                    table_user.ScrollLine(_userList.Count);
                    table_user.SelectedIndex = _userList.Count;
                }

                var messageType = addUserResponse.Result == Constants.Result.Success ? TType.Success : TType.Error;
                Generic.ShowMessage(this.ParentForm, addUserResponse.Message, messageType);
            }
        }

        private async void btn_removeBatch_Click(object sender, EventArgs e)
        {
            if (!_userList.Any(x => x.IsSelected == true))
            {
                Generic.ShowMessage(this.ParentForm, "请勾选需要删除的用户", TType.Error);

                return;
            }

            foreach (var user in _userList)
            {
                if (user.IsSelected)
                {
                    await _userManager.DeleteUserAsync(new UserDeleteDto { Id = user.Id });
                }
            }
            await LoadTableData();
            Generic.ShowMessage(this.ParentForm, "更新用户数据完成", TType.Success);
        }

        private async void btnSaveAuth_Click(object sender, EventArgs e)
        {
            var authUpdateDto = new AuthUpdateDto();

            // 工程师
            var engineerAuthControlList = Generic.GetChildControls(panel_engineerAuth);
            var engineerAuths = new List<string>();
            
            foreach (var item in engineerAuthControlList)
            {
                if (item is AntdUI.Checkbox checkBox && checkBox.Checked)
                {
                    engineerAuths.Add(checkBox.Text);
                }
            }
            
            authUpdateDto = new AuthUpdateDto()
            {
                Auths = string.Join(",", engineerAuths),
                Role = "工程师"
            };
            var updateEngineerAuthResponse = await _authManager.UpdateAuthByRoleAsync(authUpdateDto);
            if (updateEngineerAuthResponse.Result == Constants.Result.Fail) Generic.ShowMessage(this.ParentForm, updateEngineerAuthResponse.Message, TType.Error);
            
            // 操作员
            var operatorAuthControlList = Generic.GetChildControls(panel_operatorAuth);
            var operatorAuths = new List<string>();
            foreach (var item in operatorAuthControlList)
            {
                if (item is AntdUI.Checkbox checkBox && checkBox.Checked)
                {
                    operatorAuths.Add(checkBox.Text);
                }
            }
            authUpdateDto = new AuthUpdateDto()
            {
                Auths = string.Join(",", operatorAuths),
                Role = "操作员"
            };
            var updateOperatorAuthResponse = await _authManager.UpdateAuthByRoleAsync(authUpdateDto);
            if (updateOperatorAuthResponse.Result == Constants.Result.Fail) Generic.ShowMessage(this.ParentForm, updateOperatorAuthResponse.Message, TType.Error);

            // 访客
            var visitorAuthControlList = Generic.GetChildControls(panel_visitorAuth);
            var visitorAuths = new List<string>();
            foreach (var item in visitorAuthControlList)
            {
                if (item is AntdUI.Checkbox checkBox && checkBox.Checked)
                {
                    visitorAuths.Add(checkBox.Text);
                }
            }
            authUpdateDto = new AuthUpdateDto()
            {
                Auths = string.Join(",", visitorAuths),
                Role = "访客"
            };
            var updateVisitorAuthResponse = await _authManager.UpdateAuthByRoleAsync(authUpdateDto);
            if (updateVisitorAuthResponse.Result == Constants.Result.Fail) Generic.ShowMessage(this.ParentForm, updateVisitorAuthResponse.Message, TType.Error);

            if (updateEngineerAuthResponse.Result == Constants.Result.Success && updateOperatorAuthResponse.Result == Constants.Result.Success && updateVisitorAuthResponse.Result == Constants.Result.Success)
            {
                Generic.ShowMessage(this.ParentForm, "保存权限成功", TType.Success);
            }

        }
    }
}
