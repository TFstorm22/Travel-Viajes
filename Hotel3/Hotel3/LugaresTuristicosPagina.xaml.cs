using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hotel3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LugaresTuristicosPagina : ContentPage
    {
        public IList<LugarTuristico> Lugares { get; private set; }
        public LugaresTuristicosPagina(Ciudad ciudad)
        {
            Lugares = ciudad.Lugares;
            InitializeComponent();
            Nombre.Text = ciudad.Nombre;
            Pref.Text = "Preferencias para " + ciudad.Nombre;
            BindingContext = this;
        }
        async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is LugarTuristico lugar)
            {
                await Navigation.PushAsync(new LugarTuristicoPagina(lugar));
            }
        }
    }
}