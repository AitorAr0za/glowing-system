using EjercicioGigante.Enums;
using EjercicioGigante.Interfaces;
namespace EjercicioGigante.Modelos
{
    class ProductoElectronico : IProducto
    {
        public string Nombre {  get; set; }
        public double Precio {  get; set; }
        public CategoriaProducto CategoriaProducto {  get; set; }
        public ProductoElectronico(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
            CategoriaProducto = CategoriaProducto.Electronica;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Electronico - Nombre: {Nombre}\nPrecio: {Precio}");
        }
    }
}
