using System;
namespace Intervalo
{
    class Program
    {
        static void Main(string[] args)
        {/*Programa que reciba un número desde el teclado (entre 1 y 12) y que
          muestre el nombre del mes que corresponda a dicho número (usar Switch)*/
            //Decalraciondevariables
            double mes;
            //Entradadedatos
            Console.WriteLine("Ingresa un numero del 1-12 y te dire el mes");
            mes=double.Parse(Console.ReadLine());

            //Proceso
            switch (mes)
            {case 1:
                    Console.WriteLine("El mes es enereo");
                    break;
                case 2:
                    Console.WriteLine("El mes es febreo");
                    break;
                case 3:
                    Console.WriteLine("El mes es Marzo");
                    break;
                case 4:
                    Console.WriteLine("El mes es Abril");
                    break;
                case 5:
                    Console.WriteLine("El mes es Mayo");
                    break;
                case 6:
                    Console.WriteLine("El mes es Junio");
                    break;
                case 7:
                    Console.WriteLine("El mes es Julio");
                    break;
                case 8:
                    Console.WriteLine("El mes es Agosto");
                    break;
                case 9:
                    Console.WriteLine("El mes es Septiembre");
                    break;
                case  10:
                    Console.WriteLine("El mes es Octubre");
                    break;
                case 11:
                    Console.WriteLine("El mes es Noviembre");
                    break;
                case 12:
                    Console.WriteLine("El mes es Diciembre");
                    break;
                default:
                    Console.WriteLine("Ingresa un valor valido");
                    break;
            }

            //Salida
            //Pausa
            Console.WriteLine("Presiona cualquier tecla  para continuar");
            Console.ReadKey();


        }
    }
}
