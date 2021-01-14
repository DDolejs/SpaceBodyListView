using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ListViewAppMVOP.Model;
using Xamarin.Essentials;

namespace ListViewAppMVOP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPageMan : ContentPage
    {
        public ListViewPageMan()
        {
            InitializeComponent();
            Bodies pModel = new Bodies();
            BindingContext = pModel;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            Page p = new AManPage(((((ListView)sender).SelectedItem) as Model.Body), (BindingContext as Bodies).AllBodies);
            NavigationPage np = new NavigationPage(p);
            await Application.Current.MainPage.Navigation.PushAsync(np);

            if ((sender as ListView) != null)
                (sender as ListView).SelectedItem = null;
        }
    }
}
