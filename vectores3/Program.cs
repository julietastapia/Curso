using System;
namespace ciclos5
{
    class Program
    {
        static void Main(string[] args)
        {
          //Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
          //El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan 
          //sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            //CADENA FUENTE: “La mar estaba serena"
            //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            //CADENA RESULTADO: “Li mir estibi sereni"


                char[] frase = new char[30];
                char letraActual;
                char letraNueva;
                char letra;
                int indice = 0;

                Console.WriteLine("Ingrese una letra:");
                letra = char.Parse(Console.ReadLine());

                while(letra != '0' && indice < 30){
                    frase[indice] = letra;
                    Console.WriteLine("Ingrese otra letra: ");
                    letra = char.Parse(Console.ReadLine());
                    indice++;
                }

                frase[indice]= '\0';
                Console.WriteLine("La frase fuente es: ");
                indice =0;
                while (frase[indice] != '\0'){
                    Console.Write(frase[indice]);
                    indice++;
                }
                
                Console.WriteLine("Ingrese letra a reemplazar: ");
                letraActual = char.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la letra nueva: ");
                letraNueva = char.Parse(Console.ReadLine());

                indice = 0;
                while(frase[indice] != '\0'){
                    if (frase [indice] == letraActual)
                    frase[indice] = letraNueva;

                    indice++;
                
                }

                Console.WriteLine("La Frase nueva es: ");
                indice = 0;
                while(frase[indice] != '\0'){
                    Console.Write(frase[indice]);
                    indice++;
                }

//--------------------------------------------------------------------------------------------------------------------------------
            // una manera mas facil de hacerlo:

           // string frase;
           // char letraAActual;
           // char letrANueva;

           // Console.WriteLine("Ingrese la frase: ");
           // frase = Console.ReadLine();
          //  Console.WriteLine("Ingrese la letra a reemplazar: ");
          //  letraActual = char.Parse(Console.ReadLine());
           // Console.WriteLine("Ingrese nueva letra: ");
          // letrANueva = char.Parse(Console.ReadLine());

          //  frase = frase.Replace(letraActual, letrANueva);
          //  Console.WriteLine("La cadena nueva es: ");
          //  Console.WriteLine(frase);







        }
    }
}