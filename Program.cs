using System;

namespace practica3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Crear un programa que muestre las letras de la Z (mayúscula) a la A (mayúscula, descendiendo).

             char a;

             for(a='Z'; a>='A'; a--)
             { 
             Console.WriteLine(a);
             }
             

            //Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while". 

            /* int b = 1;
              do {

                   Console.WriteLine(b);
                   b++;

              }

            while(b<=10);
            */

            //Crear un programa que pida números positivos al usuario, y vaya calculando la suma de todos ellos (terminará cuando se teclea un número negativo o cero).

            /*int e=0;
             int d;
             int suma=0;

           do {
             Console.WriteLine("Ingresu un valor:");
              d= Convert.ToInt32(Console.ReadLine());

              if(d < 0)
              {
               Console.WriteLine("La suma de los numeros es:"+suma);
               Environment.Exit(1);
              }
              else
              {
                suma = suma + d;



              e++;


              }
            }
            while(d != 0);
  Console.WriteLine("La suma de los numeros es:"+suma);
            */

            // Crear un programa que muestre los primeros 10 números pares a partir del producto de (10 x 10)    

            /*int g=10*10;
            Console.WriteLine("los primeros 10 numeros pares de "+ g +" son :");


            for(g=1; g<=20; g++)
            {
              if(g%2==0)
              {
                Console.WriteLine(g);
              }
            }

            */
        }
    }
}
