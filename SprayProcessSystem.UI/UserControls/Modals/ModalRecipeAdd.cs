using AntdUI;
using Mapster;
using Microsoft.Extensions.DependencyInjection;
using SprayProcessSystem.BLL.Dto.RecipeDto;
using SprayProcessSystem.BLL.Managers;
using SprayProcessSystem.Helper;
using SprayProcessSystem.Model;
using SprayProcessSystem.Model.Entities;
using static SprayProcessSystem.Model.Constants;

namespace SprayProcessSystem.UI.UserControls.Modals
{
    public partial class ModalRecipeAdd : UserControl
    {
        private readonly RecipeManager _recipeManager;

        public bool IsSubmit { get; set; }

        public ModalRecipeAdd()
        {
            InitializeComponent();
            _recipeManager = Program.ServiceProvider.GetRequiredService<RecipeManager>();
            this.Load += (s, e) =>
            {
                txt_receipeName.Select();
            };
        }

        private async void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_receipeName.Text == string.Empty)
            {
                Generic.ShowMessage(this.ParentForm, "请输入配方名称", AntdUI.TType.Warn);
                return;
            }
            var dict = new Dictionary<string, string>();
            foreach (var item in this.Controls)
            {
                if (item is RecipeSetParameter recipeSetParameter)
                {
                    dict.Add(recipeSetParameter.ParameterName, recipeSetParameter.ParameterValue);
                }
            }

            var recipeEntity = new RecipeEntity();
            foreach (var property in recipeEntity.GetType().GetProperties())
            {
                var sugarColumnAttribute = AttributeHelper.GetPropertyAttribute<SqlSugar.SugarColumn>(
                    typeof(RecipeEntity),
                    property.Name
                );

                if (sugarColumnAttribute != null && !string.IsNullOrEmpty(sugarColumnAttribute.ColumnDescription))
                {
                    var key = sugarColumnAttribute.ColumnDescription;
                    if (dict.ContainsKey(key))
                    {
                        property.SetValue(recipeEntity, dict[key]);
                    }
                }
            }
            var dto = recipeEntity.Adapt<RecipeAddDto>();
            dto.ProductType = txt_receipeName.Text.ToString();
            var updateRecipeResponse = await _recipeManager.AddRecipeAsync(dto);
            if (updateRecipeResponse.Result == Constants.Result.Success)
            {
                Generic.AppendLog($"添加配方 {dto.ProductType} 成功", LogLevelEnum.Info, true);
            }
            else
            {
                Generic.ShowMessage(this.ParentForm, updateRecipeResponse.Message, TType.Error);
                return;
            }

            IsSubmit = true;
            this.Dispose();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            IsSubmit = false;
            this.Dispose();
        }
    }
}
