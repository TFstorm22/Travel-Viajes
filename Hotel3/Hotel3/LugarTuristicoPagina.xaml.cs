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
    public partial class LugarTuristicoPagina : ContentPage
    {
        public IList<LugarTuristico> Lugares{ get; private set; }
        public LugarTuristicoPagina(LugarTuristico lugar)
        {
            InitializeComponent();
            Imagen.Source = lugar.Img;
            Nombre.Text = lugar.Nombre;
            Direccion.Text = lugar.Direccion;
            Descripcion.Text = lugar.Descripcion;
            Precio.Text = lugar.Precio;
        }
    }
}