using System;
namespace funcion1
{
    class Program
    {
        static void Main(string[] args)
        {
         //Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
         //Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla
         // el monto total a pagar. Usar la función.
        

         Console.Write("Ingrese precio articulo: $");
         float precio = float.Parse(Console.ReadLine());
         Console.Write("Ingrese la cantidad: ");
         int cantVendida = int.Parse(Console.ReadLine());

         float total = producto(precio, cantVendida);
         Console.WriteLine("El total es: $" + total.ToString("0.00"));





        }
        static float producto(float a, int b){
           return a*b;
        }

    }
}