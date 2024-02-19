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
        {
            if (sender is Button btn)
            {
               
                Type?type = Assembly.GetExecutingAssembly().GetType("mytest.Oem." + btn.BindingContext.ToString());
                this.MainFrame.Content = (View)Activator.CreateInstance(type);
            }
            else
            {
                this.MainFrame.Content = null;
            }
        }
    }

}
