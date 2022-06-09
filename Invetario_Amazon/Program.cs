using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Invetario_Amazon
{
    class Program
    {

        class Inventario 
        {

            //Campos
            string Nom_Prod;
            string Des;
            float Prec;
            int stock;


            //Metodos
            public void Almazenar ()
            {
                StreamWriter sw = new StreamWriter("Productos.txt", true);

                try
                {
                    

                    Console.Clear();
                    Console.WriteLine("---Almacenar---");
                    Console.Write("Nombre del producto: ");
                    Nom_Prod = Convert.ToString(Console.ReadLine());
                    Console.Write("Descripcion del producto: ");
                    Des = Convert.ToString(Console.ReadLine());
                    Console.Write("Precio del producto: ");
                    Prec = Single.Parse(Console.ReadLine());
                    Console.Write("stock  del producto: ");
                    stock = Convert.ToInt32(Console.ReadLine());

                    sw.WriteLine("Nombre del producto: " + Nom_Prod);
                    sw.WriteLine("Descripcio: " + Des);
                    sw.WriteLine("Precio: {0:C}", Prec);
                    sw.WriteLine("strock: " + stock);

                    
                }
                catch (IOException e)
                {
                    Console.WriteLine("\nError: " + e.Message);
                   
                }
                finally
                {
                    
                    Console.Write("\nENTER para terminar..........");
                    sw.Close();
                    Console.ReadKey();
                    Console.Clear();
                }
            }
             
            public void  Desplegar()
            {
                Console.Clear();

                try
                {
                    Console.WriteLine("Nombre del producto: " + Nom_Prod);
                    Console.WriteLine("Descripcio: " +  Des);
                    Console.WriteLine("Precio: {0:C}", Prec);
                    Console.WriteLine("strock: " + stock);

                    Console.Write("\nENTER para terminar..........");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (IOException e)
                {
                    Console.WriteLine("\nError: " + e.Message);

                }
            }



        }
        static void Main(string[] args)
        {
            //variable 
            int opc;

           

            //creacion del objeto 
            Inventario I = new Inventario();

            //menu de opciones
            do
            {
                Console.Clear();
                Console.WriteLine("---Inentario---");
                Console.WriteLine("1 Almacenar datos");
                Console.WriteLine("2 Imprimir los ultimos datos almacenados");
                Console.WriteLine("3 Salida del programa");
                Console.Write("Que opción desea del menu: ");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        //Bloque de escritura
                        try
                        {
                            I.Almazenar();
                            
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine("\nError: " + e.Message);
                            Console.WriteLine("\nRuta: " + e.StackTrace);
                        }
                        break;
                    case 2:
                        //bloque de lectura
                        try
                        {
                            I.Desplegar();
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine("\nError: " + e.Message);
                            Console.WriteLine("\nRuta: " + e.StackTrace);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nPresione <ENTER> para Salir del Programa...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Write("\nEsa Opción no Existe !!.\nPresione ENTER para Continuar...");
                        Console.ReadKey();
                        break;

                }
            } while (opc != 3);
        }
    }
}
