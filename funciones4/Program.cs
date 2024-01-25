using System;
namespace funcion4
{
    class Program
    {
        static void Main(string[] args)
        {
        // Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” 
        //que reciba un número por valor y una variable por referencia. Que analice el número y escriba 
        //variable recibida por referencia con:

            //a. 1 si el número es positivo.
            //b. -1 si el número es negativo.
            //c. 0 si el número es cero.

            int n, estado =9;
                Console.WriteLine("Ingrese un nro: ");
                n = int.Parse(Console.ReadLine());

                 PosNegCero(n, ref estado);
                 Console.Write("El estado del valor: " + n + " es: " + estado);

        }


        static void PosNegCero(int a, ref int j){

        if(a > 0)
         j = 1;
        if(a < 0)
         j = -1;
        if(a == 0)
         j = 0;
        }
    }
}