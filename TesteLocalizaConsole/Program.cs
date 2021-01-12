using System;
using System.Collections.Generic;

namespace TesteLocalizaConsole
{
    class Program
    {
        public static bool CheckDivisor(int number, int divisor)
        {
            return number % divisor == 0;
        }

        public static bool CheckPrimeNumber(int number)
        {
            if (number == 1) return false;
            
            for( int i=2; i<= number/2; i++)
            {
                if ((number % i) == 0) return false;
            }

            return true;
        }
        public static void CalculateDivisor(bool isPrime)
        {
            Console.Write("\r\nDigite o número para  realizar o calculo: ");
            var number = Convert.ToInt32(Console.ReadLine());

            if (VerifyNumber(number))
            {

                List<int> ListDivisors = new List<int>();
                for (int i = 1; i <= number; i++)
                {
                    if (CheckDivisor(number, i))
                    {
                        
                       ListDivisors.Add(i);
                    }
                }

               
               

                if (isPrime)
                {
                    List<int> ListPrimes = new List<int>();
                    foreach( var item in ListDivisors)
                    {
                        if(CheckPrimeNumber(item))
                        {
                            ListPrimes.Add(item);
                        }
                    }
                    ListDivisors = ListPrimes;
                    PrintResult($"Os divisores são: {string.Join(",", ListDivisors)}");
                } else
                {
                    PrintResult($"Os divisores são: {string.Join(",", ListDivisors)}");
                }
                
          
            } else
            {
                PrintResult("O número inserido não é válido!");
               
            }      
        }

        public static void PrintResult(string mensagem)
        {
            Console.WriteLine($"\r\n{mensagem}");
            Console.ReadLine();
        }


        public static bool VerifyNumber(int number)
        {
            return number > 0;
            
        }

        public static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opçao:");
            Console.WriteLine("1 - Decompor um número e todos os seus divisores.");
            Console.WriteLine("2 - Decompor um número e todos os seus divisores e enumerar os números primos");
            Console.WriteLine("3 - Exit");
            Console.Write("\r\nDigite uma opçao: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CalculateDivisor(false);
                    return true;
                case "2":
                    CalculateDivisor(true);
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }



        static void Main(string[] args)
        {

            bool mostrarMenu = true;
            while (mostrarMenu)
            {
                mostrarMenu = Menu();
            }


        }
    }
}
