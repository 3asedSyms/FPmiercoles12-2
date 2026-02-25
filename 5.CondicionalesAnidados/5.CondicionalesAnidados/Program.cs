using System;

namespace _5.CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Ingrese el valor del numero 1");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el blor del numero 2");
            num2 = Convert.ToInt32((string)Console.ReadLine());
            Console.WriteLine("Ingrese el valor del numero 3");
            num3 = Int32.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"El numero mayor es : {num1}");
                }
                else
                { 
                    Console.WriteLine($"El numero mayor es: {num3}");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"El numero mayor es: {num2}");
                    Console.WriteLine($"El numero mayor es: {num2}");
                }
                else
                {
                    Console.WriteLine($"El numero mayor es: {num3}");
                }
            }
        }
    }
}