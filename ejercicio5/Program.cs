using System;
namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule 
            //y emita por pantalla el promedio final.

           int n1, n2, n3, promedio;
            
            Console.WriteLine("Ingrese las notas del alumno: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese las notas del alumno: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese las notas del alumno: ");
            n3 = int.Parse(Console.ReadLine());

           
           promedio = (n1 + n2 + n3) / 3;

            
            Console.WriteLine("El promedio es: " + promedio);
            
        }
    }
}