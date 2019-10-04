using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VincularPropriedade
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<Pessoa> pessoas { get; set; }
        public MainPage()
        {
            InitializeComponent();

            pessoas.Add( new Pessoa() { ID = 1, Nome = "José", Pais = "Brasil" } );
            pessoas.Add( new Pessoa() { ID = 2, Nome = "Maria", Pais = "Estados Unidos" } );
            pessoas.Add( new Pessoa() { ID = 3, Nome = "Pedro", Pais = "Peru" } );
            pessoas.Add( new Pessoa() { ID = 4, Nome = "Thiago", Pais = "Brasil" } );
            pessoas.Add( new Pessoa() { ID = 5, Nome = "Elias", Pais = "Reino Unido" });

            listview.ItemsSource = pessoas;

            
        }
    }
}
