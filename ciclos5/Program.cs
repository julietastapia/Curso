using System;
namespace ciclos5
{
    class Program
    {
        static void Main(string[] args)
        {
         //Hacer un programa que solicite 20 números y luego emitir por pantalla
         // el máximo de los números pares y el mínimo de los números impares.

            int n, max = 0, min = 0;
            int conPar = 0, conImpar = 0;
            

            for(int x = 0; x < 20 ; x++)
            {

            Console.WriteLine("Ingrese 20 nros: ");
            n = int.Parse(Console.ReadLine());

            if ( n %2 == 0){
                    conPar++;
                if (conPar == 1)
                    max = n;
                else if ( n > max)
                max = n;

            }
            else{
                conImpar++;

                if (conImpar == 1)
                min = n;
                else if( n< min)
                min = n;
            }


            }
            Console.WriteLine("El mayor de los pares es: " + max);
            Console.WriteLine("El menor de los impares es: " + min);
            
        }
    }
}