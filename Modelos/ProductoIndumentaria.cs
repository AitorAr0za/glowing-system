using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioGigante.Enums;
using EjercicioGigante.Interfaces;

namespace EjercicioGigante.Modelos
{
    class ProductoIndumentaria : IProducto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public CategoriaProducto CategoriaProducto { get; set; }
        public ProductoIndumentaria(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
            CategoriaProducto = CategoriaProducto.Ropa;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Indumentaria - Nombre: {Nombre}\nPrecio: {Precio}");
        }
    }
}
