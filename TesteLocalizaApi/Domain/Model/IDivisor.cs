using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteLocalizaApi.Domain.Model
{
    public class IDivisor
    {
        public bool OK { get; set; }
        public string Erro { get; set; }

        public IList<int> Divisors { get; set; }
    }
}
