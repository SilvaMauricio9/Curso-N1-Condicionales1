using System;
using System.Runtime.InteropServices;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero
            int a, b, c, suma, producto;
            Console.WriteLine("Ingrese un numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el ultimo numero: ");
            c = int.Parse(Console.ReadLine());

            suma = a + b;
            producto = b * c;

            if(suma > producto){
                Console.WriteLine("La suma de los dos primero es mayor al producto..");
            }
            Console.WriteLine("Fin del Programa");
        }
    }
}
