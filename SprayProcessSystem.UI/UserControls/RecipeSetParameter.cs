using System.ComponentModel;

namespace SprayProcessSystem.UI.UserControls
{
    public partial class RecipeSetParameter : UserControl
    {
        public RecipeSetParameter()
        {
            InitializeComponent();
        }

        private string _parameterName;
        [Description("参数名称")]
        [Category("自定义属性")]
        [Browsable(true)]
        public string ParameterName
        {
            get { return _parameterName; }
            set
            {
                _parameterName = value;
                lbl_name.Text = value;
            }
        }

        private string _parameterValue;
        [Description("参数值")]
        [Category("自定义属性")]
        [Browsable(true)]
        public string ParameterValue
        {
            get { return _parameterValue; }
            set
            {
                _parameterValue = value;
                txt_value.Text = value;
            }
        }

        private string _parameterUnit;
        [Description("参数单位")]
        [Category("自定义属性")]
        [Browsable(true)]
        public string ParameterUnit
        {
            get { return _parameterUnit; }
            set
            {
                _parameterUnit = value;
                lbl_unit.Text = value;
            }
        }


        private int _increment;
        [Description("步进值")]
        [Category("自定义属性")]
        [Browsable(true)]
        public int Increment
        {
            get { return _increment; }
            set { 
                _increment = value;
                txt_value.Increment = value;

            }
        }

        private void txt_value_TextChanged(object sender, EventArgs e)
        {
            ParameterValue = txt_value.Text;
        }
    }
}
