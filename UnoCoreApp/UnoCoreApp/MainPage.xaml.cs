using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using UnoCoreApp.Views;

namespace UnoCoreApp
{
    public partial class MainPage : ContentPage
    {
        MainLogo myLogo = new MainLogo { logo= "logoCircular.png" };

        public MainPage()
        {
            InitializeComponent();
            BindingContext = myLogo;
        }

        async void GoMenu_Clicked(object sender, System.EventArgs e)
        {
            //var menuPage = new NavigationPage(new ShowMenu(0));
            var menuPage = new NavigationPage(new InitPage());
            await Navigation.PushModalAsync(menuPage);
        }
    }

    public class MainLogo
    {
        public string logo { get; set; }
    }
}
