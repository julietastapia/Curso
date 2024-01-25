using System;
namespace condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros 
            //vendidos según la siguiente escala:

           // Si vende menos de 100 litros, no hay descuento.
            //Si vende entre 101 y 300 litros, el descuento es del 10%.
            //Si vende entre 301 y 500 litros, el descuento es del 15%.
            //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            //Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de 
            //litros vendidos y calcule y emita el importe con el descuento  aplicado..

                float litros, descuento, venta, total;

                Console.WriteLine("Ingrese importe de la venta: ");
                venta = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese cantidad de litros vendidos: ");
                litros = float.Parse(Console.ReadLine());

                if (litros >= 500){
                    descuento = venta * 25 / 100;
                    total = venta - descuento;
                    Console.WriteLine("Tiene 25% OFF, el total a abonar es: $" + total);
                }
                else if (litros >= 300 && litros < 500){
                    descuento = venta * 15 /100;
                    total = venta - descuento;
                    Console.WriteLine("Tiene 15% OFF, el total a abonar es: $" + total);
                }
                else if (litros >= 100 && litros < 300){
                    descuento = venta * 10 / 100;
                    total = venta - descuento;
                    Console.WriteLine("Tiene 10% OFF, el total a abonar es: $" + total);
                }
                else{
                    Console.WriteLine( "Abona: $" + venta);
                }




        }
    }
}