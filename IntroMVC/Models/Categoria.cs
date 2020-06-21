using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IntroMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage ="Favor Preencher!")]
        public string Descricao { get; set; }

       // public List<Produto> Produtos { get; set; }
    }
}
