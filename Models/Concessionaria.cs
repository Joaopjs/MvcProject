using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Models
{
    public class Concessionaria
    {
        [Key]
        public int concId { get; set; }
        public string Nome { get; set; }
        public string endereco { get; set; }
    }
}
