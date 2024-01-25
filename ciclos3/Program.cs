using System;
namespace ciclos1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

            int edad, promedio, acu =0;

            Console.WriteLine("Ingrese 20 edades: ");
            for(int x= 0; x<20; x++){
                edad = int.Parse(Console.ReadLine());
                acu+=edad;
            }
            promedio = acu / 20;
            Console.WriteLine("El promedio es: " + promedio);







        }
    }
}