using System;

namespace A133590.Ejercicio25
{
    class Program
    {   
        static bool validarEntero(string ingreso, out int resultado)
        {
            bool exito = Int32.TryParse(ingreso, out resultado);
            if(!exito)
            {
                Console.WriteLine("Ingreso inválido. Terminando ejecución..");
                return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 25");
            Console.WriteLine("Programa que determina si 3 números ingresados forman una fecha válida.");
            int dia, mes, anyo;

            Console.Write("Por favor, ingrese el dia: ");
            bool exito = validarEntero(Console.ReadLine(), out dia);
            if (!exito) return;

            Console.Write("Por favor, ingrese el mes: ");
            exito = validarEntero(Console.ReadLine(), out mes);
            if (!exito) return;

            Console.Write("Por favor, ingrese el año: ");
            exito = validarEntero(Console.ReadLine(), out anyo);
            if (!exito) return;

            try
            {
                DateTime fecha = new DateTime(anyo, mes, dia);
                exito = true;
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                exito = false;
            }

            if (exito)
            {
                Console.WriteLine("La fecha ingresada es válida.");
            }
            else
            {
                Console.WriteLine("La fecha ingresada no es válida.");
            }

            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}
