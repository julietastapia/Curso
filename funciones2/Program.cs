using System;
namespace funcion2
{
    class Program
    {
        static void Main(string[] args)
        {
         //Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero
         // si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares

            int num,resultado;
            int cont = 0;

            Console.WriteLine("Ingrese nro: ");

            for(int x = 0; x <20 ; x ++){
                num = int.Parse(Console.ReadLine());

                resultado = par(num);

                if(resultado == 1)
                cont++;

            }

            Console.WriteLine("Cantidad de pares ingresados: " + cont);





        }
      static int par(int a){
        if (a % 2 == 0){
            return 1;
        }
        else {
            return 0;
        }
      }

    }
}