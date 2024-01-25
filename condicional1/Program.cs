using System;
namespace condicional1
{
    class Program
    {
        static void Main(string[] args)
        {
          //Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio 
          //si “Es mayor a 10” o “No es mayor a 10”.  

            int num;

            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            if (num > 10){
                Console.WriteLine("Es Mayor a 10");
            }
            else{
                Console.WriteLine("No es mayor a 10");
            }
        }
    }
}