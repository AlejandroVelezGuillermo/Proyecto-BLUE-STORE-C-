using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_proyecto_blue_2
{
    internal class Producto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public double PxU { get; set; }
        public int Cantidad { get; set; }

        public Producto(int codigo, string nombre, double pxu, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            PxU = pxu;
            Cantidad = cantidad;

        }
    }
}
