using System;
namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado
            //por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por 
            //pantalla el sueldo total a cobrar por el mismo.

            float TotalFacturado, SueldoTotal,comision; 
            
            
            Console.WriteLine("Ingrese el total facturado ");
            TotalFacturado = float.Parse(Console.ReadLine());

            comision = 5 * TotalFacturado /100;

            SueldoTotal = 15000 + comision;
            
            Console.WriteLine("El sueldo total es: $" + SueldoTotal);
            
        }
    }
}