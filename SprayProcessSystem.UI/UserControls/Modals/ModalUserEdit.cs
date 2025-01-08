using SprayProcessSystem.BLL.Dto.UserDto;
using SprayProcessSystem.Helper;
using SprayProcessSystem.Model;
using Window = System.Windows.Forms.Form;

namespace SprayProcessSystem.UI.UserControls.Modals
{
    public partial class ModalUserEdit : UserControl
    {
        private readonly Window _window;
        private readonly UserAddUpdateDto _user;
        public bool Submit { get; set; }

        public string UserName { get; set; }

        public ModalUserEdit(Window window, UserAddUpdateDto user)
        {
            InitializeComponent();
            _window = window;
            _user = user;

            var list = EnumHelper.GetAllEnumDescriptionArray<Constants.RoleEnum>();
            select_role.Items.AddRange(list.Select(x => x.Description).ToArray());
            this.Font = new Font(Global.FontCollection.Families[0], 10);
            InitData();
        }



        private void InitData()
        {
            txt_userName.Text = _user.UserName;
            txt_nickName.Text = _user.NickName;
            select_role.SelectedValue = _user.Role;
            switch_enabled.Checked = _user.IsEnabled;
        }



        private void btn_ok_Click(object sender, EventArgs e)
        {
            //input_name.Status = AntdUI.TType.None;
            ////检查输入内容
            if (string.IsNullOrEmpty(txt_userName.Text))
            {
                txt_userName.Status = AntdUI.TType.Error;
                AntdUI.Message.warn(this.ParentForm, "用户名不能为空！", autoClose: 3);
                return;
            }

            _user.UserName = txt_userName.Text;
            _user.NickName = txt_nickName.Text;
            _user.Role = (string)select_role.SelectedValue;
            _user.Password = txt_password.Text;
            _user.IsEnabled = switch_enabled.Checked;
            Submit = true;
            this.Dispose();
        }



        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Submit = false;
            this.Dispose();
        }
    }
}
