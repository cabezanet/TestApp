using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //text.Text = "You clicked me";
            (sender as Button).Text = "You clicked me";
        }

        private void goSecondPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SecondPage());
        }

    }
}
