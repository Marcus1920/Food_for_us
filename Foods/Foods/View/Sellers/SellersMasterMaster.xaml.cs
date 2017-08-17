using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Foods.View.Sellers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SellersMasterMaster : ContentPage
    {
        public ListView ListView;

        public SellersMasterMaster()
        {
            InitializeComponent();

            BindingContext = new SellersMasterMasterViewModel();
            ListView = MenuItemsListView;
        }

        class SellersMasterMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<SellersMasterMenuItem> MenuItems { get; set; }

            public SellersMasterMasterViewModel()
            {
                MenuItems = new ObservableCollection<SellersMasterMenuItem>(new[]
                {
                    new SellersMasterMenuItem { Id = 0, Title = "Home", TargetType = typeof(SellersTabbedPage)},
                    new SellersMasterMenuItem { Id = 1, Title = "Page 2", TargetType = typeof(SellersMasterDetail) }
                });
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