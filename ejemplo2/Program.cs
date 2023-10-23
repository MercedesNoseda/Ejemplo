using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primer lote con 10 registros de productos, cada producto tiene:
            //-Codigo Articulo (3 digitos no correlativos)
            //Precio
            //-Codigo de Marca
            //Segundo lote con las ventas de la semana. Cada venta tiene:
            //-Codigo Articulo
            //-Cantidad
            //-Codigo Cliente (1 al 100)
            //Este lote corta con el Codigo de Cliente en cero


            //Creo un vector de articulo para guardar los articulos
            Articulo[] articulos = new Articulo[10];

            //En el art en el indice 6, en el Cod de marca asignale un tres. Yo agarro c/u de los indices del vector de arts
            //y dentro de cada uno de esos indices hay un art, con su atributo. Entonces yo parado en ese indice puedo trabajar ç
            //en cada uno de los atributos
            for (int x = 0; x < 10; x++)
            {
                articulos[x] = new Articulo();
                Console.WriteLine("Ingrese los datos del producto");
                Console.WriteLine("Codigo: ");
                articulos[x].CodArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precios");
                articulos[x].Precio = int.Parse(Console.ReadLine());
                Console.WriteLine("Marca (1 al 10)");
                articulos[x].CodMarca = int.Parse(Console.ReadLine());  

                //con esto ya cargo el vector completo con los 10 articulos

            }

            //Cargo el lote de ventas
            Venta venta = new Venta();
            Console.WriteLine("Ingrese la venta");
            //lo pongo primero porque es el que corta
            Console.WriteLine("Codigo de Cliente");
            venta.CodigoCliente = int.Parse(Console.ReadLine());   
            
            while (venta.CodigoCliente != 0)
            {
                Console.WriteLine("Codigo de Articulo");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad");
                venta.Cantidad = int.Parse(Console.ReadLine());

                //aca trabajamos 


                //vuelvo a pedir cliente
                Console.WriteLine("Codigo de Cliente");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }
        }
    }
}
