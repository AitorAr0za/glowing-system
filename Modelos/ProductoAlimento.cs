using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioGigante.Enums;
using EjercicioGigante.Interfaces;

namespace EjercicioGigante.Modelos
{
    class ProductoAlimento : IProducto
    {
        public string Nombre {  get; set; }
        public double Precio { get; set; }
        public CategoriaProducto CategoriaProducto { get; set; }
        public ProductoAlimento(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
            CategoriaProducto = CategoriaProducto.Alimento;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Alimento - Nombre: {Nombre}\nPrecio: {Precio}");
        }
    }
}
