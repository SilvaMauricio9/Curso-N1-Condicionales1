﻿using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:
            //Si vende menos de 100 litros, no hay descuento.
            //Si vende entre 101 y 300 litros, el descuento es del 10%.
            //Si vende entre 301 y 500 litros, el descuento es del 15%.
            //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            //Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..
            float importe, litro;
            Console.WriteLine("Ingrese importe");
            importe = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los litros que desea:");
            litro = float.Parse(Console.ReadLine());

            if(litro > 100 && litro <= 300)
               importe *= 0.90f;
            else if(litro > 300 && litro <= 500)
               importe *= 0.85f;
            else if(litro > 500)
               importe *= 0.75f;

            Console.WriteLine("El importe final a pagar es de: " + importe);


        }
    }
}