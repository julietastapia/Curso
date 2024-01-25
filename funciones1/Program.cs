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
         float precio, total;
        int cantVendida;

         Console.Write("Ingrese precio articulo: $");
         precio = float.Parse(Console.ReadLine());
         Console.Write("Ingrese la cantidad: ");
         cantVendida = int.Parse(Console.ReadLine());

         total = producto(precio, cantVendida);
         Console.WriteLine("El total es: $" + total.ToString("0.00"));





        }
        static float producto(float a, int b){
            float r;
            r = a * b;
            return r;
        }

    }
}