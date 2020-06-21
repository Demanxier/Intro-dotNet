using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IntroMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Favor Preencher!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Favor Preencher!")]
        public int Quantidade { get; set; }

        
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
