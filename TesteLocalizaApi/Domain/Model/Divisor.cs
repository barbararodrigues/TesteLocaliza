using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteLocalizaApi.Model
{
    public class Divisor
    {
      
        [Required]
        public int Number { get; set; }
        public bool Prime { get; set; }

      
    }
}
