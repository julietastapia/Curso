using System;
namespace condicional3
{
    class Program
    {
        static void Main(string[] args)
        {
           //Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
            int n1,n2,n3,n4, menor;

            Console.Write("Ingrese nro ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese nro ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese nro ");
            n3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese nro ");
            n4 = int.Parse(Console.ReadLine());

            menor = n1;
                if( n1 < menor){
                    
                    menor = n1;
                    } 
                else if (n2 < menor){
                    menor = n2;
                }
                else if (n3 < menor){
                    menor = n3;
                }
                else if (n4 < menor){
                    menor = n4;
                }
            Console.WriteLine("El menor es: " + menor);




        }
    }
}