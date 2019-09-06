using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCenter.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MedicalCenter.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            this.BindingContext = new HomeMenuViewModel();
        }

        private void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
        }
    }
}
