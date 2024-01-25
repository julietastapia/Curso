using System;
namespace ciclos5
{
    class Program
    {
        static void Main(string[] args)
        {
        // Hacer un programa para ingresar 10 números. 
        //El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

            int n, con, ConPrimos = 0;

            Console.WriteLine("Ingrese los nros: ");
            for( int x = 0 ; x < 10 ; x++){

                n = int.Parse(Console.ReadLine());
                con++; //se inicializa acá porque el contador podría contar el numero anterior.

                for(int y= 1 ; y < n; y++){
                    if ( n % y == 0)
                    con++;
                    if ( con == 2)
                    ConPrimos++;
                }
              }
            Console.WriteLine("La cantidad de primos ingresados son: " + ConPrimos);

        }
    }
}