using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaClaseAsig1
{
    public class convertMoneda
    {
        
        public static void Monedas()
        {
            double euro, yen, resultado, colon;
            Console.WriteLine("Bienvenido al conversor de monedas, Elija una opción:");
            Console.WriteLine("1- Convertir Dólares a Euros ");
            Console.WriteLine("2- Convertir Dólares a Yenes japoneses");
            Console.WriteLine("3- Convertir Dólares a Colones");

            int opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el monto en dólares a convertir");
            double cantidad = Convert.ToDouble(Console.ReadLine());

            euro =0.85;
            yen = 109.66;
            colon = 8.75;

            switch (opcion)
            {
                case 1:
                    resultado = cantidad * euro;
                    Console.WriteLine($"${cantidad} es igual a {resultado} euros");
                    break;

                case 2:
                    resultado = cantidad * yen;
                    Console.WriteLine($"${cantidad} es igual a {resultado} yenes");
                    break;

                case 3:
                    resultado = cantidad * colon;
                    Console.WriteLine($"${cantidad} es igual a {resultado} colones");
                    break;

                default:
                    Console.WriteLine("Lo sentimos, opción no válida");
                    break;

            }


        }
        

    }
}
