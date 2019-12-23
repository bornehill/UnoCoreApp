using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnoCoreApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnoCoreApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShowMenu : ContentPage
	{
		public ShowMenu (int parent)
		{
			InitializeComponent ();
            var menu = MenuData.GetMenuOptionByParent(parent);
            BindingContext = menu;
        }

        void GoSubMenu_Clicked(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var selected = e.SelectedItem as MenuOption;
            var menu = MenuData.GetMenuOptionByParent(selected.Id);
            BindingContext = menu;
        }
    }
}