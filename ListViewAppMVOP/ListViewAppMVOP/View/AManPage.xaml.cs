using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ListViewAppMVOP.Model;
using System.ComponentModel;

namespace ListViewAppMVOP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class PageViewModel:INotifyPropertyChanged
    {        
        public event PropertyChangedEventHandler PropertyChanged;

        public PageViewModel(Body body)
        {
            
        }

        string _Name;
        public string Name
        {
            get { return _Name; }
            set 
            {
                _Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); 
            }
        }

        string _Gravity;
        public string Gravity
        {
            get { return _Gravity; }
            set
            {
                _Gravity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Gravity"));
            }
        }

         
       

        public Body ToABody()
        {
            Body am = new Body
            {
                Name = this.Name,
                Gravity = this.Gravity,
                
            };

            return am;
        }
    }

    public partial class AManPage : ContentPage
    {
        ObservableCollection<Body> oCollection;

        public AManPage()
        {
            InitializeComponent();
        }

        public AManPage(Body m, ObservableCollection<Body> collection)
        {
            InitializeComponent();
            PageViewModel pvm = new PageViewModel(m);
            BindingContext = pvm;
            oCollection = collection;
        }

        private void Save_Button_Clicked(object sender, EventArgs e)
        {
            oCollection.Add((BindingContext as PageViewModel).ToABody());
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}