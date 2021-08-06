using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMvcBoot.Models
{
    public class Agencias : BaseModels
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }
    }
}