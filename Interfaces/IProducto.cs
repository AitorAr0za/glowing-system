using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioGigante.Enums;

namespace EjercicioGigante.Interfaces
{
    public interface IProducto
    {
        string Nombre { get; set; }
        double Precio { get; set; }
        CategoriaProducto CategoriaProducto { get; set; }
        void MostrarDetalles();

    }
}

