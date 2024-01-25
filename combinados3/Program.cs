using System;
namespace ciclos5
{
    class Program
    {
        static void Main(string[] args)
        {
       //Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
      // El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

        int n = 1, conPositivos;
        Console.WriteLine("Ingrese numeros: ");


        while ( n >= 0){
        n = int.Parse(Console.ReadLine());
            
                conPositivos = 0;
            while ( n > 0){
                conPositivos++;


                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("La cantidad de numeros ingresado por grupo es: " + conPositivos);

        }
        


        }
    }
}