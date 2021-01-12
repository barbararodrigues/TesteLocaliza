using System;
using System.Collections.Generic;
using TesteLocalizaApi.Model;
using TesteLocalizaApi.Services;
using Xunit;

namespace TesteLocalizaTestes
{
    public class DivisorTest
    {
    
       
        [Fact]
        public void ErroNumberInvalid()
            {
    
                DivisorServices divisorService = new DivisorServices();
                Divisor divisor = new Divisor();
                divisor.Number = 0;
                divisor.Prime = false;

             
                var response = divisorService.CalculateDivisor(divisor);

                Assert.False(response.OK);
                Assert.Equal("O número não é válido!", response.Erro);
 
            }


        [Fact]
        public void DivisorSucess()
        {
           
            DivisorServices divisorService = new DivisorServices();
            Divisor divisor = new Divisor();
            divisor.Number = 21;
            divisor.Prime = false;
            var listResponse = new List<int> { 1, 3, 7, 21 };
            var response = divisorService.CalculateDivisor(divisor);

            Assert.True(response.OK);
            Assert.Null(response.Erro);
            Assert.Equal(listResponse, response.Divisors);
        }

        [Fact]
        public void DivisorPrimeSucess()
        {
            
            DivisorServices divisorService = new DivisorServices();
            Divisor divisor = new Divisor();
            divisor.Number = 21;
            divisor.Prime = true;

            var listResponse = new List<int> { 3, 7 };
            var response = divisorService.CalculateDivisor(divisor);

          
            Assert.True(response.OK);
            Assert.Null(response.Erro);
            Assert.Equal(listResponse, response.Divisors);
        }


    }
}
