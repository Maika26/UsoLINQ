using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseDatos bd = new BaseDatos();
            //AGREGAR EL PROCESADOR MANUELMENTE POR CODIGO
            /*procesadore procesador1 = new procesadore();
            procesador1.marca = "Intel";
            procesador1.plataforma = "Intel";
            procesador1.modelo = "4100F";
            procesador1.linea = "i3";
            procesador1.socket = "LGA 1151-v2";
            procesador1.velocidad = "3.5GHz";
            procesador1.stock = 12;
            procesador1.precio = 99990;
            procesador1.cantidad_nucleos = 4;*/

            /*int opcion = 0;
            while (opcion == 0)
            {
                //AGREGAR EL PROCESADOR POR CONSOLA PREGUNTANDO AL USUARIO
                procesadore procesador2 = new procesadore();
                Console.WriteLine(" Ingrese la marca del procesador: ");
                procesador2.marca = Console.ReadLine();
                Console.WriteLine(" Ingrese la plataforma del procesador: ");
                procesador2.plataforma = Console.ReadLine();
                Console.WriteLine(" Ingrese el modelo del procesador: ");
                procesador2.modelo = Console.ReadLine();
                Console.WriteLine(" Ingrese la linea del procesador: ");
                procesador2.linea = Console.ReadLine();
                Console.WriteLine(" Ingrese el socket del procesador: ");
                procesador2.socket = Console.ReadLine();
                Console.WriteLine(" Ingrese la velocidad del procesador: ");
                procesador2.velocidad = Console.ReadLine();
                Console.WriteLine(" Ingrese el stock del procesador: ");
                procesador2.stock = int.Parse(Console.ReadLine());
                Console.WriteLine(" Ingrese el precio del procesador: ");
                procesador2.precio = int.Parse(Console.ReadLine());
                Console.WriteLine(" Ingrese la cantidad de nucleos del procesador: ");
                procesador2.cantidad_nucleos = int.Parse(Console.ReadLine());
                bd.procesadores.Add(procesador2); //PARA GUARDAR EL PROCESADOR EN C#
                bd.SaveChanges();  //LINEA PARA QUE SE GUARDEN LOS CAMBIOS REALIZADOS EN LA BASE DE DATOS EN SQL
                Console.WriteLine("Procesador guardado correctamente");
                break;
            }*/

            //CONSULTAS DESDE C#
            //SELECCIONAR EL PROCESADOR MAS CARO

            var procesadoresOrdenados = bd.procesadores.OrderByDescending(p => p.precio).ToList(); //OBTENER LA LISTA DE LOS PROCESADORES ORDENADOS DE MAYOR A MENOR PRECIO
            var procesadorCaro = procesadoresOrdenados.First(); //OBTENER EL MAS CARO DE LA LISTA

            //var resultado = bd.procesadores.Max(p => p.precio); //PARA SELECCIONAR EL PRECIO MAS CARO

            //SELECCIONAR EL PROCESADOR CON MENOS STOCK

            var stockProcesadores = bd.procesadores.OrderBy(p => p.stock).ToList();
            var menorStock = stockProcesadores.First();

            //SELECCIONAR LOS PROCESADORES CON STOCK > 0

            var procesadoresDisponibles = bd.procesadores.Where(p => p.stock > 0).ToList();

            //SELECCIONAR LOS PROCESADORES INTEL

            var procesadoresIntel = bd.procesadores.Where(p => p.marca.Equals("Intel")).ToList();

            //SELECCIONAR LOS PROCESADORES AMD

            var procesadoresAmd = bd.procesadores.Where(p => p.marca.Equals("AMD")).ToList();

            //SELECCIONAR LOS PROCESADORES INTEL QUE TENGAN STOCK > 0

            var intelStock = bd.procesadores.Where(p => p.marca.Equals("Intel") && p.stock > 0).ToList();

            //SELECCIONAR SOLO EL PROCESADOR CON ID 5

            var procesadoreId5 = bd.procesadores.Where(p => p.id == 5).First();

            //BUSCAR PROCESADOR POR ID

            var procesadorBuscado = bd.procesadores.Find(6);


            Console.ReadKey();

        }
    }
}
