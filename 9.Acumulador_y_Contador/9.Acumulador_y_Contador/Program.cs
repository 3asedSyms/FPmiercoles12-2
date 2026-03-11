using System;


namespace _9.Acumulador_y_Contador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // generar los primeros cinco numeros y sumarlos hasta llegar a 15
            /*
                        int contador = 1;
                        int acumulador = 0;

                        while (contador <= 5)
                        {
                            acumulador += contador;
                            Console.WriteLine($"
                            contador++;

                        }
                        Console.WriteLine($"La suma de los cinco números enteros es:{acumulador}");
                 */


            int numero = 0;
            int contador = 1;
            int acumulador = 1;
            int newNum = 0;

            Console.WriteLine("Ingrese un numero");

            numero = int.Parse(Console.ReadLine());

            while (contador <= numero)
            {
                acumulador = contador * numero;
                contador ++;                      
                newNum = contador * acumulador;
            }
            
            Console.WriteLine(newNum);
        }
    }
}
