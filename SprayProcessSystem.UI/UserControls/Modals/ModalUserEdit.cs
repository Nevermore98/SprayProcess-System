using AntdUI;
using Microsoft.Extensions.DependencyInjection;
using SprayProcessSystem.BLL.Dto.UserDto;
using SprayProcessSystem.BLL.Managers;
using SprayProcessSystem.Helper;
using SprayProcessSystem.Model;

namespace SprayProcessSystem.UI.UserControls.Modals
{
    public partial class ModalUserEdit : UserControl
    {
        private readonly Form _form;
        private readonly UserAddUpdateDto _user;
        private readonly bool _isEdit;
        private readonly UserManager _userManager;
        public bool Submit { get; set; }

        public string UserName { get; set; }
        
        public ModalUserEdit(Form form, UserAddUpdateDto user, bool isEdit = true)
        {
            InitializeComponent();
            this.Load += (s, e) =>
            {
                if (txt_userName.Enabled)
                {
                    txt_userName.Select();
                }
                else
                {
                    txt_nickName.SelectAll();
                }
            };

            _form = form;
            _user = user;
            _isEdit = isEdit;
            _userManager = Program.ServiceProvider.GetRequiredService<UserManager>();

            var list = EnumHelper.GetAllEnumDescriptionArray<Constants.RoleEnum>();
            select_role.Items.AddRange(list.Where(x=>x.Description != "开发者").Select(x => x.Description).ToArray());
            this.Font = new Font(Global.FontCollection.Families[0], 10);
            InitData();
        }



        private void InitData()
        {
            txt_userName.Text = _user.UserName;
            txt_nickName.Text = _user.NickName;
            select_role.SelectedValue = _user.Role;
            switch_enabled.Checked = _user.IsEnabled;

            if (_isEdit)
            {
                lbl_password.Visible = false;
                txt_password.Visible = false;
                txt_userName.Enabled = false;
            }

            AntdUI.TooltipComponent tooltip = new AntdUI.TooltipComponent()
            {
                Font = new Font(Global.FontCollection.Families[0], 10)
            };
            tooltip.SetTip(txt_userName, "账号名不区分大小写");

        }



        private async void btn_ok_Click(object sender, EventArgs e)
        {
            //检查输入内容
            if (string.IsNullOrEmpty(txt_userName.Text))
            {
                txt_userName.Status = AntdUI.TType.Error;
                Generic.ShowMessage(_form, "账号名不能为空！", TType.Warn);
                return;
            }
            if (string.IsNullOrEmpty(txt_nickName.Text))
            {
                txt_nickName.Status = AntdUI.TType.Error;
                Generic.ShowMessage(_form, "昵称不能为空！", TType.Warn);
                return;
            }
            if (string.IsNullOrEmpty(txt_password.Text) && !_isEdit)
            {
                txt_password.Status = AntdUI.TType.Error;
                Generic.ShowMessage(_form, "密码不能为空！", TType.Warn);
                return;
            }
            if (string.IsNullOrEmpty((string)select_role.SelectedValue))
            {
                Generic.ShowMessage(_form, "角色不能为空！", TType.Warn);
                return;
            }

            _user.UserName = txt_userName.Text;
            _user.NickName = txt_nickName.Text;
            _user.Role = (string)select_role.SelectedValue;

            if (!_isEdit)
            {
                _user.Password = txt_password.Text;
            }
            
            _user.IsEnabled = switch_enabled.Checked;

            if (!_isEdit)
            {
                var isExistResponse = await _userManager.IsUserExistAsync(new UserIsExistDto() { UserName = _user.UserName });
                if (isExistResponse.Result == Constants.Result.Success)
                {
                    Submit = true;
                    this.Dispose();
                }
                else
                {
                    Generic.ShowMessage(_form, isExistResponse.Message, TType.Warn);
                }
            }
            else
            {
                Submit = true;
                this.Dispose();
            }
        }



        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Submit = false;
            this.Dispose();
        }
    }
}
