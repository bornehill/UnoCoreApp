using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using UnoCoreApp.Models;
using UnoCoreApp.Views;

namespace UnoCoreApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InitPage : MasterDetailPage
    {
        public InitPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuOption;
            if (item == null)
                return;

            var page = new ShowMenu(item.Id);
            page.Title = item.Name;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}