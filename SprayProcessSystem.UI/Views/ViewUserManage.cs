using AntdUI;
using Mapster;
using Microsoft.Extensions.DependencyInjection;
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

        public ViewUserManage()
        {
            _userManager = Program.ServiceProvider.GetRequiredService<UserManager>();

            InitializeComponent();

            InitTableColumns();
            LoadTableData();
        }

        private void InitTableColumns()
        {
            //table_user.SetRowEnable(0, false, true);
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

        private async void LoadTableData()
        {
            _userList.Clear();
            var queryAllUserResponse = await _userManager.QueryAllUserAsync();
            var userList = queryAllUserResponse.Data;
            _userList.AddRange(userList.Select(x => x.Adapt<User>()).ToArray());
            Console.WriteLine(_userList);
            table_user.Binding(_userList);

            // 禁用默认管理员账号
            var index = _userList.IndexOf(_userList.FirstOrDefault(x => x.UserName == "Admin"));
            table_user.SetRowEnable(index, false, true);
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
                        if (form.Submit)
                        {
                            userAddUpdateDto.UpdatedAt = DateTime.Now;
                            var updateUserResponse = await _userManager.UpdateUserAsync(userAddUpdateDto);

                            var messageType = updateUserResponse.Result == Constants.Result.Success ? TType.Success : TType.Error;
                            Generic.ShowMessage(this.ParentForm, updateUserResponse.Message, messageType);
                            LoadTableData();
                        }
                        break;
                    case "删除":
                        var modalResult = Generic.ShowModal(this.ParentForm, "删除用户", $"确定要删除用户 {user.UserName} 吗？", TType.Warn);

                        if (modalResult == DialogResult.OK)
                        {
                            var deleteUserResponse = await _userManager.DeleteUserAsync(new UserDeleteDto { Id = user.Id, UserName = user.UserName });
                            if (deleteUserResponse.Result == Constants.Result.Success) LoadTableData();

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

            var form = ActivatorUtilities.CreateInstance<ModalUserEdit>(Program.ServiceProvider, this.ParentForm, userAddUpdateDto);
            form.Size = new Size(300, 350);
            AntdUI.Modal.open(new AntdUI.Modal.Config(this.ParentForm, "添加用户", form, TType.Info)
            {
                BtnHeight = 0,
                Keyboard = false,
                Font = new Font(Global.FontCollection.Families[0], 11),
                MaskClosable = true,
            });
            if (form.Submit)
            {
                var addUserResponse = await _userManager.AddUserAsync(userAddUpdateDto);
                if (addUserResponse.Result == Constants.Result.Success) LoadTableData();

                var messageType = addUserResponse.Result == Constants.Result.Success ? TType.Success : TType.Error;
                Generic.ShowMessage(this.ParentForm, addUserResponse.Message, messageType);
            }
        }
    }

}
