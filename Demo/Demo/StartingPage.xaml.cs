using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartingPage : ContentPage
    {
        public StartingPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProfilePage());
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}