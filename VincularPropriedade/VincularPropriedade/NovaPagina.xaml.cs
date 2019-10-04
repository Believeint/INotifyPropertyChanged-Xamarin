using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VincularPropriedade
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovaPagina : ContentPage
    {
        public NovaPagina()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FiltroView());
        }
    }
}