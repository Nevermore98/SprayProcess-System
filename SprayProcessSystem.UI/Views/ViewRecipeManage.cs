using AntdUI;
using IoTClient.Enums;
using Mapster;
using Masuit.Tools;
using Microsoft.Extensions.DependencyInjection;
using MiniExcelLibs;
using SprayProcessSystem.BLL.Dto.RecipeDto;
using SprayProcessSystem.BLL.Dto.UserDto;
using SprayProcessSystem.BLL.Managers;
using SprayProcessSystem.Helper;
using SprayProcessSystem.Model;
using SprayProcessSystem.Model.Entities;
using SprayProcessSystem.UI.UserControls;
using SprayProcessSystem.UI.UserControls.Modals;
using static SprayProcessSystem.Model.Constants;

namespace SprayProcessSystem.UI.Views
{
    public partial class ViewRecipeManage : UserControl
    {
        private readonly RecipeManager _recipeManager;
        private AntList<RecipeEntity> _recipeList = new();
        private RecipeEntity _currentRecipe;

        public ViewRecipeManage()
        {
            InitializeComponent();
            _recipeManager = Program.ServiceProvider.GetRequiredService<RecipeManager>();

            InitControls();
            BindEvents();
            this.Load += ViewRecipeManage_Load;
        }

        private async void ViewRecipeManage_Load(object? sender, EventArgs e)
        {
            await LoadRecipe();
        }

        private void InitControls()
        {
            table_recipe.EditMode = TEditMode.DoubleClick;
            table_recipe.LostFocusClearSelection = false;
            table_recipe.Radius = 0;
            table_recipe.VisibleHeader = false;
            table_recipe.Columns = new ColumnCollection()
            {
                new Column("ProductType", "产品类型", ColumnAlign.Center)
                {
                    Width="180",
                    SortOrder = true
                },
            };

        }
        private void BindEvents()
        {
            table_recipe.SelectIndexChanged += async (s, e) =>
            {
                if (table_recipe.SelectedIndex == -1) return;
                _currentRecipe = _recipeList[table_recipe.SelectedIndex - 1];
                panel_recipeDetail.Visible = true;
                var queryRecipeResponse = await _recipeManager.QueryRecipeByIdAsync(new RecipeQueryById() { Id = _currentRecipe.Id });
                if (queryRecipeResponse.Result == Constants.Result.Success)
                {
                    var data = queryRecipeResponse.Data[0].Adapt<RecipeEntity>();

                    // 字典存放 RecipeEntity 的每个字段的中文描述及其值
                    var dict = new Dictionary<string, string>();
                    foreach (var property in data.GetType().GetProperties())
                    {
                        var value = property.GetValue(data).ToString();
                        if (value != null)
                        {
                            var sugarColumnAttribute = AttributeHelper.GetPropertyAttribute<SqlSugar.SugarColumn>(
                                 typeof(RecipeEntity),
                                 property.Name
                             );

                            if (sugarColumnAttribute != null && !string.IsNullOrEmpty(sugarColumnAttribute.ColumnDescription))
                            {
                                dict.Add(sugarColumnAttribute.ColumnDescription, value);
                            }
                        }
                    }
                    foreach (var item in panel_recipeDetail.Controls)
                    {
                        if (item is RecipeSetParameter recipeSetParameter)
                        {
                            var key = recipeSetParameter.ParameterName;
                            if (dict.ContainsKey(key))
                            {
                                recipeSetParameter.ParameterValue = dict[key];
                            }
                        }
                    }
                }
            };


            table_recipe.CellEndEdit += (s, e) =>
            {
                Console.WriteLine(e);
                string newProductType = e.Value.ToString();
                Console.WriteLine(_currentRecipe);
                if (_recipeList.Any(x => x.ProductType == newProductType))
                {
                    Generic.ShowMessage(this.ParentForm, $"产品类型 {newProductType} 已存在", TType.Warn, false);
                    return false;
                }
                _currentRecipe.ProductType = newProductType;
                var updateRecipeResponse = _recipeManager.UpdateRecipeAsync(_currentRecipe.Adapt<RecipeUpdateDto>()).GetAwaiter().GetResult();
                if (updateRecipeResponse.Result == Constants.Result.Success)
                {
                    LoadRecipe().GetAwaiter();
                    Generic.AppendLog($"重命名配方 {_currentRecipe.ProductType} 成功", LogLevelEnum.Info, true);
                }
                return true;
            };

            btn_refresh.Click += async (s, e) =>
            {
                await LoadRecipe();
                table_recipe.SelectedIndex = -1;
                panel_recipeDetail.Visible = false;
            };

            btn_add.Click += (s, e) =>
            {
                table_recipe.SelectedIndex = -1;
                panel_recipeDetail.Visible = false;

                var form = ActivatorUtilities.CreateInstance<ModalRecipeAdd>(Program.ServiceProvider);
                form.Size = new Size(700, 600);
                Generic.ShowModal(this.ParentForm, "新增配方", form, TType.Info, false);
                // 提交编辑
                // TODO
                if (form.IsSubmit)
                {

                }
            };

            btn_import.Click += async (s, e) =>
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Excel files(*.xlsx)|*.xlsx";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var filePath = fileDialog.FileName;
                        var rows = MiniExcel.Query<ResultRecipeQueryDto>(filePath).ToList();

                        //查询数据库的配方，如果导入的配方名称数据库没有就添加，如果有就更新
                        var queryAllRecipeResponse = await _recipeManager.QueryAllRecipeAsync();
                        if (queryAllRecipeResponse.Result == Constants.Result.Success)
                        {
                            var queryRecipeList = queryAllRecipeResponse.Data;
                            foreach (var row in rows)
                            {
                                var dbRow = queryRecipeList.FirstOrDefault(x => x.ProductType == row.ProductType);
                                if (dbRow != null)
                                {
                                    //更新
                                    var updateDto = row.Adapt<RecipeUpdateDto>();
                                    updateDto.Id = dbRow.Id;
                                    var res = await _recipeManager.UpdateRecipeAsync(updateDto);
                                    if (res.Result != Constants.Result.Success)
                                    {
                                        Generic.AppendLog("导入失败:" + res.Message, LogLevelEnum.Error, true);
                                        return;
                                    }
                                }
                                else
                                {
                                    //添加
                                    var addDto = row.Adapt<RecipeAddDto>();
                                    var res = await _recipeManager.AddRecipeAsync(addDto);
                                    if (res.Result != Constants.Result.Success)
                                    {
                                        Generic.AppendLog("导入失败:" + res.Message, LogLevelEnum.Error, true);
                                        return;
                                    }
                                }

                            }
                            Generic.AppendLog("导入成功", LogLevelEnum.Info, true);
                            await LoadRecipe();
                        }
                        else
                        {
                            Generic.AppendLog($"导入失败：{queryAllRecipeResponse.Message}", LogLevelEnum.Error, true);

                        }
                    }
                    catch (Exception ex)
                    {
                        Generic.AppendLog($"导入失败：{ex.Message}", LogLevelEnum.Error, true);
                    }
                }

            };

            btn_export.Click += (s, e) =>
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files(*.xlsx)|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var filePath = saveFileDialog.FileName;
                        MiniExcel.SaveAs(filePath, _recipeList);
                        Generic.AppendLog("导出成功", LogLevelEnum.Info, true);
                    }
                    catch (Exception ex)
                    {
                        Generic.AppendLog($"导出失败：{ex.Message}", LogLevelEnum.Error, true);
                    }
                }
            };


            btn_download.Click += (s, e) =>
            {
                if (!Global.SiemensClient.Connected)
                {
                    Generic.ShowMessage(this.ParentForm, "请先连接西门子客户端", TType.Warn, false);
                    return;
                }

                var modalResult = Generic.ShowModal(this.ParentForm, "下载到 PLC", "确定下载到 PLC 吗？", TType.Warn);
                if (modalResult == DialogResult.OK)
                {
                    foreach (var item in panel_recipeDetail.Controls)
                    {
                        if (item is RecipeSetParameter control)
                        {
                            if (control.ParameterValue == string.Empty)
                            {
                                control.ParameterValue = "0";
                            }
                            if (control.ParameterName == "离心风机过载上限值") control.ParameterName = "冷却室离心风机过载上限值";

                            if (!Generic.PlcWrite(control.ParameterName, control.ParameterValue, DataTypeEnum.Float))
                            {
                                Generic.ShowMessage(this.ParentForm, $"{control.ParameterName} 下载失败", TType.Error, true);
                                return;
                            }
                        }
                    }
                    Generic.ShowMessage(this.ParentForm, "下载到 PLC 成功", TType.Success, true);
                };
            };

            btn_save.Click += async (s, e) =>
            {
                var dict = new Dictionary<string, string>();
                foreach (var item in panel_recipeDetail.Controls)
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
                var dto = recipeEntity.Adapt<RecipeUpdateDto>();
                dto.Id = _currentRecipe.Id;
                dto.CreatedAt = _currentRecipe.CreatedAt;
                dto.UpdatedAt = _currentRecipe.UpdatedAt;
                var updateRecipeResponse = await _recipeManager.UpdateRecipeAsync(dto);
                if (updateRecipeResponse.Result == Constants.Result.Success)
                {
                    await LoadRecipe();
                    Generic.AppendLog($"保存配方 {_currentRecipe.ProductType} 成功", LogLevelEnum.Info, true);
                }
                else
                {
                    Generic.AppendLog(updateRecipeResponse.Message, LogLevelEnum.Error, true);
                }

            };

            btn_delete.Click += async (s, e) =>
            {
                var deleteRecipeResponse = await _recipeManager.DeleteRecipeAsync(new RecipeDeleteDto() { Id = _currentRecipe.Id });
                if (deleteRecipeResponse.Result == Constants.Result.Success)
                {
                    await LoadRecipe();
                    table_recipe.SelectedIndex = -1;
                    panel_recipeDetail.Visible = false;
                }
                else
                {
                    Generic.AppendLog(deleteRecipeResponse.Message, LogLevelEnum.Error, true);
                }
            };

        }



        private async Task LoadRecipe()
        {
            var queryAllRecipeResponse = await _recipeManager.QueryAllRecipeAsync();
            if (queryAllRecipeResponse.Result == Constants.Result.Success)
            {
                _recipeList.Clear();
                // 只有 add 才会触发通知
                _recipeList.AddRange(queryAllRecipeResponse.Data.Select(x => x.Adapt<RecipeEntity>()));
                table_recipe.Binding(_recipeList);
            }
            else
            {
                Generic.AppendLog(queryAllRecipeResponse.Message, LogLevelEnum.Error, true);
            }
        }
    }
}
