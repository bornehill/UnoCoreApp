using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnoCoreApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnoCoreApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InitPageMaster : ContentPage
    {
        public ListView ListView;

        public InitPageMaster()
        {
            InitializeComponent();

            BindingContext = new InitPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class InitPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MenuOption> MenuItems { get; set; }
            
            public InitPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MenuOption>(MenuData.GetMenuOptionByParent(0).Options.ToArray<MenuOption>());
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}