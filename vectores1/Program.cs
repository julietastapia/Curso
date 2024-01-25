using System;
namespace ciclos5
{
    class Program
    {
        static void Main(string[] args)
        {
                //Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
                //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

                int[] numeros = new int [10];
               

                Console.WriteLine("Ingrese 10 nros: ");
                
                for(int x = 0 ; x < 10; x++){
                    numeros [x] = int.Parse(Console.ReadLine());
                    
                }

                int mayor= numeros[0];
                int posicion = 1;

                for(int x = 0; x < 10 ; x ++){
                    
                        if(numeros[x] > mayor){
                        mayor = numeros[x];
                        posicion = x + 1;
                        }
                    }

                    Console.WriteLine("El mayor nro ingresado es: " + mayor);
                    Console.WriteLine("En la posicion: " + posicion);
        }
    }
}