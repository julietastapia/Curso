using System;
namespace ciclos1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de 10 números
            // y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.
            
            int num, mayor = 0;

            Console.WriteLine("Ingrese numeros: ");
            for(int x = 0; x < 10; x++){
                num = int.Parse(Console.ReadLine());
                if(num > mayor){
                    mayor = num;
                }
            }
                Console.WriteLine("El nro mayor ingresado es: " + mayor);

        }
    }
}