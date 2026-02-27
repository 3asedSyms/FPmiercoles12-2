using System;

namespace CondicionalesAnidados2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1 = 0;
            float nota2 = 0;
            float nota3 = 0;
            float promedio = 0;

            Console.WriteLine("Ingrese la nota 1");
            nota1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota2");
            nota2 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 3");
            nota3 = Single.Parse(Console.ReadLine());
            promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio >= 9.5 && promedio <=10.0)
            {
                Console.WriteLine("Excelente");
            } else
            {
                if (promedio >= 9.4 && promedio < 9.5) 
                {
                    Console.WriteLine("Muy Bien");
                }else
                {
                    if (promedio >= 7.5 && promedio < 8.5)
                    {
                        Console.WriteLine("Bien");
                    }
                    else
                    {
                        Console.WriteLine("Promeido error");
                    }
                }
            }

        }
    }
}
