using System;
namespace ciclos5
{
    class Program
    {
        static void Main(string[] args)
        {
        /* Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro
         con los siguientes datos:
          - Número de Artículo (1 a 15)
          -Cantidad Vendida 
        Puede haber varios registros para el mismo artículo y el último se indica con número de 
        artículo igual a 0.
        Se pide determinar e informar:
          a) El número de artículo que más se vendió en total.
          b) Los números de artículos que no registraron ventas.
          c) Cuantas unidades se vendieron del número de artículo 10.*/

            int Art, cantVendida;
            int[] totalCantidadVendida = new int [15]; // se genera un vector para acumular la cantidad vendida para cada articulo
            
            for (int x = 0; x < 15; x++)
            {
                totalCantidadVendida[x] 0;
             }

             Console.WriteLine("Ingrese codigo de artículo: ");
             Art = int.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese cantidad vendida: ");
             cantVendida = int.Parse(Console.ReadLine());   



             while ( Art != 0){

                    totalCantidadVendida[Art-1] += cantVendida; //para que el usuario pueda cargar en el indice del vector

             Console.WriteLine("Ingrese codigo de artículo: ");
             Art = int.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese cantidad vendida: ");
             cantVendida = int.Parse(Console.ReadLine());  

             }

            //punto a: buscar un maximo y su posicion

            int maxCantidad = totalCantidadVendida[0];
            int nroMaximo = 1;
            for (int x = 0; x < length; x++)
            {
                if (totalCantidadVendida[x] > maxCantidad){
                    maxCantidad = totalCantidadVendida[x];
                    Art = x + 1;
                }
            }

            Console.WriteLine("El producto mas vendido es el: " + Art + "Con la cantidad de: " + maxCantidad);

            //punto b
            for (int x = 0; x < length; x++)
            {
                if(totalCantidadVendida[x]==0){
                    Console.WriteLine("El producto " + (x+1) + "no tuvo ventas.");
                }
            }
            
            //punto c
            Console.WriteLine("La cantidad vendida del articulo 10 es: " + totalCantidadVendida[9]);







        }
    }
}