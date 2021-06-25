using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Models
{
    public class Carro
    {
        [Key]
        public int CarroId { get; set; }
        public string Nome { get; set; }
        public string Profisao { get; set; }


    }
}
