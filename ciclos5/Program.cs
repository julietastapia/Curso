using System;
namespace ciclos5
{
    class Program
    {
        static void Main(string[] args)
        {
         //Hacer un programa que solicite 20 números y luego emitir por pantalla
         // el máximo de los números pares y el mínimo de los números impares.

            int maxPar = int.MinValue;
            int minImpar = int.MaxValue;

            for ( int x=0; x <20; x++)
            {
                Console.Write($"{x+1} - Ingrese hasta 20 numeros: ");
                int numero = int.Parse(Console.ReadLine());
                
                if (numero %2 == 0)
                {
                    if(numero > maxPar)
                    maxPar = numero;
                }
                else{

                    if(numero < minImpar)
                    minImpar = numero;
                }
            }

            Console.WriteLine($"El mayor de los pares es: {maxPar}");
            Console.WriteLine($"El menor de los impares es: {minImpar}");
            
        }
    }
}