using System;
namespace condicional3
{
    class Program
    {
        static void Main(string[] args)
        {
           //Hacer un programa que solicite el ingreso de dos números y luego calcular:
           //La resta si el primero es mayor que el segundo.
           //La suma si son iguales.
           //El producto si el primero es menor.
           //Se deberá emitir un cartel por pantalla con el resultado correspondiente.

            int n1, n2, r;

            Console.Write("Ingrese el primer numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero:");
            n2 = int.Parse(Console.ReadLine());

            if(n1 > n2){
                r = n1- n2;
                Console.WriteLine("La resta es: " + r);
            }
            if (n1 == n2){
                r = n1 + n2;
                Console.WriteLine("La suma es: " + r);
            }
            if( n1 < n2){
                r = n1 * n2;
                Console.WriteLine("El producto es: " + r);
            }



        }
    }
}