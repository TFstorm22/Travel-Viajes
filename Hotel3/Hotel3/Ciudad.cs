using System.Collections.Generic;
using Xamarin.Forms;

public class Ciudad
{
    public string Nombre { get; set; }
    public string Descripcion{ get; set; }
    public IList<LugarTuristico> Lugares { get; set; }
    public ImageSource Img { get; set; }
}
