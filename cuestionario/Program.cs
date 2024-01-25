using System;
namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
      int n, x , acu, cont = 0;
      n = int.Parse(Console.ReadLine());

      while(n!=0){
        x=1;
        acu=0;
            while(x<=10){
                x--;
                acu+=n+x;
                n = int.Parse(Console.ReadLine());
      
            }
            if(acu>100){
                cont++;
            }
      }
        Console.WriteLine("Hubo " + cont + "Subrgupos acumulados mayor a 100");
        }
    }
}