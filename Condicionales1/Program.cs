using System;

namespace Condicionales1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, Resultado;
            Console.WriteLine("Ingrese un numero:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro:");
            B = int.Parse(Console.ReadLine());
            
            if (A > B)
                Resultado = A - B;
            else if(A == B)
                Resultado = A + B;
            else 
                Resultado = A * B;

                Console.WriteLine("El resultado es: " + Resultado);
        }
    }
}