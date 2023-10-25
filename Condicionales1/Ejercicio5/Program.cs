using System;
using System.Runtime.InteropServices;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados
            // de forma decreciente .
            int a, b, c, d;
            Console.WriteLine("Ingrese el primer numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el ultimo numero: ");
            d = int.Parse(Console.ReadLine());

            if((a > b) && (b > c) && (c > d)){
                Console.WriteLine("Se encuentran ordenados de forma decreciente..");
            }

            Console.WriteLine("Fin del programa");

        }
    }
}
