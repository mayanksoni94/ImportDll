using ImportDll.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace ImportDll
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                // string res = string.Empty;
                var message = DependencyService.Get<IMessage>().helloMessage();
                mylabel.Text = message;
            }
            catch(Exception ex)
            {

            }
           
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                // string res = string.Empty;
                var message = DependencyService.Get<IMessage>().goodbyeMessage();
                mylabel.Text = message;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
