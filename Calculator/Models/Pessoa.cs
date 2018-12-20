using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Calculator.Models
{
    public class Pessoa
    {
        private int Id { get; set; }

        [Display(Name = "Nome")]
        [StringLength(50)]
        private string Nome { get; set; }
        private DateTime DataCadastro { get; set; }
        private DateTime DataAlterecao { get; set; }
        private string CpfCnpj { get; set; }
        private DateTime DataNascimento { get; set; }
    }
}