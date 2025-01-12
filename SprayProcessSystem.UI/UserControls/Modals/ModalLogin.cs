using AntdUI;
using Mapster;
using Microsoft.Extensions.DependencyInjection;
using NLog;
using SprayProcessSystem.BLL.Dto.UserDto;
using SprayProcessSystem.BLL.Managers;
using SprayProcessSystem.Model;
using SprayProcessSystem.UI.Models;

namespace SprayProcessSystem.UI.UserControls.Modals
{
    public partial class ModalLogin : UserControl
    {
        private readonly Form _form;
        private readonly UserManager _userManager;
        private readonly Logger _logger;

        public User CurrentUser { get; set; } = new User();
        public bool IsLoginSuccess { get; private set; }

        public string UserName { get; set; }

        public ModalLogin(Form form)
        {
            InitializeComponent();
            this.Load += (s, e) =>
            {
                txt_userName.Select();
            };

            _form = form;
            _userManager = Program.ServiceProvider.GetRequiredService<UserManager>();
            _logger = LogManager.GetCurrentClassLogger();
            this.Font = new Font(Global.FontCollection.Families[0], 10);
        }


        private async void Login()
        {
            //检查输入内容
            if (string.IsNullOrEmpty(txt_userName.Text))
            {
                txt_userName.Status = AntdUI.TType.Error;
                Generic.ShowMessage(_form, "请输入账号名", TType.Warn);
                return;
            }

            if (string.IsNullOrEmpty(txt_password.Text))
            {
                txt_password.Status = AntdUI.TType.Error;
                Generic.ShowMessage(_form, "请输入密码", TType.Warn);
                return;
            }

            var userLoginDto = new UserLoginDto();
            userLoginDto.UserName = txt_userName.Text;
            userLoginDto.Password = txt_password.Text;

            var isExistResponse = await _userManager.LoginAsync(userLoginDto);
            if (isExistResponse.Result == Constants.Result.Success)
            {
                if (isExistResponse.Data[0].IsEnabled)
                {
                    IsLoginSuccess = true;
                    CurrentUser = isExistResponse.Data[0].Adapt<User>();
                    Generic.ShowMessage(_form, isExistResponse.Message, TType.Success);
                    _logger.Info($"登录用户 {userLoginDto.UserName} 成功");
                    this.Dispose();
                }
                else
                {
                    IsLoginSuccess = false;
                    CurrentUser = null;
                    Generic.ShowMessage(_form, $"用户 {userLoginDto.UserName} 已被管理员禁用", TType.Error);
                }
            }
            else
            {
                Generic.ShowMessage(_form, isExistResponse.Message, TType.Warn);
            }
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            IsLoginSuccess = false;
            this.Dispose();
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
