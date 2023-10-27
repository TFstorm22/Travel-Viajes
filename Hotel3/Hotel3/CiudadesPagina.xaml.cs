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
    public partial class CiudadesPagina : ContentPage
    {
        public IList<Ciudad> Ciudades { get; private set; }
        public CiudadesPagina()
        {
            InitializeComponent();
            Ciudades = new List<Ciudad>
        {
            new Ciudad
            {
                Nombre = "Lima",
                Descripcion = "La capital y ciudad más grande del Perú",
                Img = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/City_of_Lima%2C_Peru.jpg/640px-City_of_Lima%2C_Peru.jpg",
                Lugares = new List<LugarTuristico>
                {
                    new LugarTuristico
                    {
                        Nombre = "Museo Larco",
                        Precio = "S/. 30",
                        Descripcion = "Un museo de arte precolombino",
                        Direccion = "Avenida Bolívar 1515, Pueblo Libre, Lima",
                        Distancia = "5 km",
                        Img = ImageSource.FromUri(new Uri("https://elperuano.pe/fotografia/thumbnail/2020/06/19/000081776M.jpg"))
                    },
                    new LugarTuristico
                    {
                        Nombre = "Parque de las Leyendas",
                        Precio = "S/. 15",
                        Descripcion = "Un zoológico y parque arqueológico",
                        Direccion = "Avenida Las Leyendas 580, San Miguel, Lima",
                        Distancia = "10 km",
                        Img = ImageSource.FromUri(new Uri("https://e.radio-grpp.io/normal/2022/09/21/522752_1318724.jpg"))
                    }
                }
            },
            new Ciudad
            {
                Nombre = "Cusco",
                Descripcion = "Una ciudad histórica conocida por su herencia incaica",
                Img = ImageSource.FromUri(new Uri("https://elperuano.pe/fotografia/thumbnail/2022/07/12/000189059M.jpg")),
                Lugares = new List<LugarTuristico>
                {
                    new LugarTuristico
                    {
                        Nombre = "Machu Picchu",
                        Precio = "S/. 152",
                        Descripcion = "La antigua ciudad inca en las montañas",
                        Direccion = "Aguas Calientes, Cusco",
                        Distancia = "75 km",
                        Img = ImageSource.FromUri(new Uri("https://www.perurail.com/wp-content/uploads/2017/10/Foto-1_Machu-Picchu-city-wonder-of-the-world-Cusco-Peru.jpg"))
                    },
                    new LugarTuristico
                    {
                        Nombre = "Sacsayhuamán",
                        Precio = "S/. 10",
                        Descripcion = "Un sitio arqueológico incaico",
                        Direccion = "Cusco, Cusco",
                        Distancia = "2 km",
                        Img = ImageSource.FromUri(new Uri("https://www.perurail.com/wp-content/uploads/2016/05/Foto-1_-Complejo-Arqueol%C3%B3gico-de-Sacsayhuaman.png"))
                    }
                }
            },
            new Ciudad
            {
                Nombre = "Arequipa",
                Descripcion = "La Ciudad Blanca, famosa por su arquitectura colonial",
                Img = ImageSource.FromUri(new Uri("https://skyperu.com/wp-content/uploads/2022/04/AREQUIPA-VOLCANES.jpg")),
                Lugares = new List<LugarTuristico>
                {
                    new LugarTuristico
                    {
                        Nombre = "Monasterio de Santa Catalina",
                        Precio = "S/. 40",
                        Descripcion = "Un monasterio colonial bien conservado",
                        Direccion = "Arequipa, Arequipa",
                        Distancia = "1 km",
                        Img = ImageSource.FromUri(new Uri("https://santacatalina.org.pe/wp-content/uploads/2020/06/santa-catalina-home.jpg"))
                    },
                    new LugarTuristico
                    {
                        Nombre = "Plaza de Armas de Arequipa",
                        Precio = "Gratis",
                        Descripcion = "La plaza principal de la ciudad",
                        Direccion = "Arequipa, Arequipa",
                        Distancia = "0.5 km",
                        Img = ImageSource.FromUri(new Uri("https://media-cdn.tripadvisor.com/media/photo-s/1b/06/ba/88/caption.jpg"))
                    }
                }
            },
            new Ciudad
{
    Nombre = "Trujillo",
    Descripcion = "Una ciudad con impresionante patrimonio histórico.",
    Img = ImageSource.FromUri(new Uri("https://www.blog.recorrido.pe/wp-content/uploads/2020/08/Trujillo-centro.jpg")),
    Lugares = new List<LugarTuristico>
    {
        new LugarTuristico
        {
            Nombre = "Huaca de la Luna",
            Precio = "S/. 15",
            Descripcion = "Un sitio arqueológico preincaico",
            Direccion = "Moche, Trujillo",
            Distancia = "8 km",
            Img = ImageSource.FromUri(new Uri("https://huacasdemoche.pe/wp-content/themes/huacasmoche/images/hm_in_re_02.jpg"))
        },
        new LugarTuristico
        {
            Nombre = "Chan Chan",
            Precio = "S/. 20",
            Descripcion = "La ciudad de barro más grande del mundo",
            Direccion = "Huanchaco, Trujillo",
            Distancia = "5 km",
            Img = ImageSource.FromUri(new Uri("https://denomades.s3.us-west-2.amazonaws.com/blog/wp-content/uploads/2020/01/16204452/Screen-Shot-2020-01-16-at-3.41.34-PM.png"))
        }
    }
},
new Ciudad
{
    Nombre = "Iquitos",
    Descripcion = "La ciudad más grande de la Amazonía peruana.",
    Img = ImageSource.FromUri(new Uri("https://www.ytuqueplanes.com/imagenes//fotos/festividades/principal-aniversario-fundacion-ciudad-iquitos.jpg")),
    Lugares = new List<LugarTuristico>
    {
        new LugarTuristico
        {
            Nombre = "Reserva Nacional Pacaya Samiria",
            Precio = "S/. 50",
            Descripcion = "Una de las áreas naturales más grandes del Perú",
            Direccion = "Iquitos, Loreto",
            Distancia = "80 km",
            Img = ImageSource.FromUri(new Uri("https://cdn.www.gob.pe/uploads/document/file/1865799/standard_WhatsApp%20Image%202021-05-04%20at%2015.39.21.jpeg.jpeg"))
        },
        new LugarTuristico
        {
            Nombre = "Mercado de Belén",
            Precio = "Gratis",
            Descripcion = "Un vibrante mercado flotante en el río Amazonas",
            Direccion = "Iquitos, Loreto",
            Distancia = "1 km",
            Img = ImageSource.FromUri(new Uri("https://cdn.getyourguide.com/img/tour/6281a783673c6.png/146.jpg"))
        }
    }
},
new Ciudad
{
    Nombre = "Cajamarca",
    Descripcion = "Famosa por su historia y eventos culturales.",
    Img = ImageSource.FromUri(new Uri("https://www.plataforma10.com.pe/viajes/wp-content/uploads/2023/05/cajamarca-aerea.webp")),
    Lugares = new List<LugarTuristico>
    {
        new LugarTuristico
        {
            Nombre = "Baños del Inca",
            Precio = "S/. 20",
            Descripcion = "Fuentes termales que datan de la época inca",
            Direccion = "Cajamarca, Cajamarca",
            Distancia = "5 km",
            Img = ImageSource.FromUri(new Uri("https://www.ytuqueplanes.com/imagenes/fotos/novedades/YTQP-Foto-1-Banos-del-Inca-Cajamarca.jpg"))
        },
        new LugarTuristico
        {
            Nombre = "Cumbemayo",
            Precio = "S/. 15",
            Descripcion = "Un complejo arqueológico con canales tallados en la roca",
            Direccion = "Cajamarca, Cajamarca",
            Distancia = "20 km",
            Img = ImageSource.FromUri(new Uri("https://elperuano.pe/fotografia/thumbnail/2022/06/14/000176739M.jpg"))
        }
    }
}
        };
            BindingContext = this;
        }
        async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Ciudad ciudad)
            {
                await Navigation.PushAsync(new LugaresTuristicosPagina(ciudad));
            }
        }
    }
}