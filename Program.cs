/// tienen que desarrollar un sistema de gestion de productos para un supermercado donde se manejen distintos
/// tipos de productos como alimentos, diferentes articulos electronicos y prendas de ropa. Cada producto
/// tiene que tener una categoria
using EjercicioGigante.Modelos;
using EjercicioGigante.Enums;
using System;
using System.Collections.Generic;
using EjercicioGigante.Interfaces;
namespace EjercicioGigante
{
    /*class Hamburguesa : ProductoAlimento
    {
        public string Toppings { get; set; }
    */
    class Program
    {
        static void Main()
        {
            List<IProducto> supermercado = new List<IProducto>()
            {
                new ProductoAlimento("Muzza", 20),
                new ProductoElectronico("Laptop", 1000),
                new ProductoIndumentaria("Jean", 50)
            };
            foreach (var producto in supermercado)
            {
                producto.MostrarDetalles();
            }

        }
    }
}
