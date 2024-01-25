using System;
namespace ciclos5
{
    class Program
    {
        static void Main(string[] args)
        {
        //Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

        //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
        //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.


        int n,conNumeros,conImpares, grupoImparesMaximo = 0, min,ConOrdenado = 0;
        double porcentajeImpares, porcentajeMaximo = -1;
        bool banderaOrdenados;
            for (int x = 0; x < 5; x++) {
                
                    conNumeros = 0; // se inicializa acá para que se reinicie en cada vuelta de grupo
                    conImpares = 0;
                    min = 0;
                    banderaOrdenados = true; // asumo que los valores estan ordenados
                    n = int.Parse(Console.ReadLine());


                    while( n != 0){

                        conNumeros++;
                        if( n %2 !=0)
                        conImpares++;

                        if (n <= min)
                        min = n;
                        else 
                        banderaOrdenados = false;


                        n = int.Parse(Console.ReadLine());
                    } // final del while

                     porcentajeImpares = conImpares * 100 / conNumeros; // se calcula fuera del while, primero el porcentaje para saber cuál es el grupo
                    if ( porcentajeImpares > porcentajeMaximo){
                        porcentajeMaximo = porcentajeImpares;
                        grupoImparesMaximo = x + 1; 
                    }

                    if ( banderaOrdenados)
                        ConOrdenado++;
            }// final del for

                    Console.WriteLine("El grupo con mayor porcentaje de impares es : " + grupoImparesMaximo);
                    Console.WriteLine("La cantidad de grupos con numeros ordenados es: " + ConOrdenado);
        }
    }
}