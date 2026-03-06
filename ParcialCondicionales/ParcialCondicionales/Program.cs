using System;


namespace ParcialCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sexo;

            int edad = 0; 

            int digito = 0;

            
            Console.WriteLine("Ingrese sexo: h o m");
            sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese edad");
            edad = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese ultimo digito doc de identidad");
            digito = int.Parse(Console.ReadLine());


            if (edad == 15)
            {
             
             bool ingles; 
            
             Console.WriteLine("Domina el ingles?");
             
             ingles = bool.Parse(Console.ReadLine());

                if (ingles  == true)
                {
                    Console.WriteLine("Grupo C");
                }
            }
            if (sexo == 'm' || sexo =='h')
            {
                if (sexo == 'm')
                {
                    if (edad >= 16 && edad <= 20)
                    {
                        if (digito == 0 || digito == 4 || digito == 8)
                        {
                            Console.WriteLine("Grupo A");
                        }
                        else 
                        {
                            Console.WriteLine("Grupo D");
                        }
                   
                    }
                    else
                    {
                        Console.WriteLine("Grupo D");
                    }
                    if (edad >= 21 && edad <= 25)
                    {
                        if (digito == 3 || digito == 7)
                        {
                            Console.WriteLine("Grupo B");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Grupo D");
                    }
                }
                if (sexo == 'h')
                {
                    if (edad >= 18 && edad <= 22)
                    {
                        if (digito == 1 || digito == 5 || digito == 9)
                        {
                            Console.WriteLine("Grupo A");
                        }
                        else
                        {
                            Console.WriteLine("Grupo D");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Grupo D");
                    }
                    if (edad >= 23 && edad <= 26)
                    {
                        if (digito == 2 || digito == 6)
                        {
                            Console.WriteLine("Grupo B");
                        }
                        else
                        {
                            Console.WriteLine("Grupo D");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Grupo D");
                    }
                }
                    
                
            }
            else
            {
                Console.WriteLine("Grupo D");
            }

        }
    }
}
