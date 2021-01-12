using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteLocalizaApi.Domain.Model;
using TesteLocalizaApi.Model;

namespace TesteLocalizaApi.Services
{
    public class DivisorServices
    {
        public IDivisor CalculateDivisor(Divisor divisor)
        {
            IDivisor response = new IDivisor();
            try
            {

              if (VerifyNumber(divisor.Number))
                {

                    List<int> ListDivisors = new List<int>();
                    for (int i = 1; i <= divisor.Number; i++)
                    {
                        if (CheckDivisor(divisor.Number, i))
                        {

                            ListDivisors.Add(i);
                        }
                    }




                    if (divisor.Prime)
                    {
                        List<int> ListPrimes = new List<int>();
                        foreach (var item in ListDivisors)
                        {
                            if (CheckPrimeNumber(item))
                            {
                                ListPrimes.Add(item);
                            }
                        }
                        response.Divisors = ListPrimes;
                        response.OK = true;

                    }
                    else
                    {
                        response.OK = true;
                        response.Divisors = ListDivisors;
                    }

                    return response;

                }
                else
                {
                    response.OK = false;
                    response.Erro = "O número não é válido!";
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.OK = false;
                response.Erro = ex.Message;
                return response;
            }
        }
        public static bool CheckDivisor(int number, int divisor)
        {
            return number % divisor == 0;
        }

        public static bool CheckPrimeNumber(int number)
        {
            if (number == 1) return false;

            for (int i = 2; i <= number / 2; i++)
            {
                if ((number % i) == 0) return false;
            }

            return true;
        }

        public static bool VerifyNumber(int number)
        {
            return number > 0;

        }
    }
}
