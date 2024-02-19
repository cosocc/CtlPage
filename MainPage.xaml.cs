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

                // 检查是否找到类型
                if (type != null)
                {
                    // 使用 Activator 创建类型的实例
                    object? viewObject = Activator.CreateInstance(type!);

                    // 将实例化的对象转换为 View 类型
                    if (viewObject is View view)
                    {
                        // 设置 MainFrame 的内容为视图对象
                        this.MainFrame.Content = view;
                    }
                    else
                    {
                        // 类型不是 View 类型，进行适当的异常处理
                        // 或者使用日志记录错误信息
                    }
                }
                else
                {
                    // 未找到类型，进行适当的异常处理
                    // 或者使用日志记录错误信息
                }
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
