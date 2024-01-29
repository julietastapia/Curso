using System;
namespace condicional3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
                int[] numeros = new int[4];

                for (int x=0; x<4,x++)
                {
                    Console.Write($"{x+1} -Ingrese hasta 4 numeros: ");
                    numeros[x] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Numeros mayores a 100: ");
                for (int x=0; x<4;x++)
                {
                    if (numeros[x] > 100)
                    {
                        Console.WriteLine($"{numeros[x]} es mayor a 100");
                    }
                }


        }
    }
}