using System.Reflection;

namespace mytest
{
    public partial class MainPage : ContentPage
    {
    

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnclickedBtn(object sender, EventArgs e)
    {   try
        {
            if (sender is Button btn)
            {
                // 构造完整的类型名称
                string typeName = "mytest.Oem." + btn.BindingContext.ToString();
                // 使用 Type.GetType() 方法查找类型
                Type? type = Type.GetType(typeName);
               
            }
            else
            {
                this.MainFrame.Content = null;
            }
                
            }
            catch (Exception ex)
            {
                // 处理异常情况，比如记录日志或者显示错误信息给用户
                Application.Current?.MainPage?.DisplayAlert("错误提示:", $"{ex.Message}", "cancel");
            }
        }
    }

}
