using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.ViewModels
{
    public class CarroViewModel
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Profisao { get; set; }

    }
}
