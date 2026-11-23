using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMVC.Models
{
    public class Eventos
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatorio")]
        [StringLength(80, MinimumLength =2, ErrorMessage ="O nome deve conter entre 2 e 80 caractere")]
        public string? Nome { get; set; }

        [Required(ErrorMessage ="A descrição é obrigatorio")]
        [MinLength(10, ErrorMessage ="A descrição deve conter pelo menos 10 caracteres")]
        public string? Descricao { get; set; }


        [Required(ErrorMessage ="Local é obrigatório")]
        [StringLength(100, MinimumLength =3, ErrorMessage ="O local é obrigatório e deve conter entre 3 e 100 caracteres")]
        public string? Local { get; set; }  

        // [Required(ErrorMessage ="Data do evento obrigatória e não pode ser anterior à data atual")]
        // public DateTime DataEvento { get; set; }

        [Required(ErrorMessage ="Quantidade de vagas entre 1 e 1000")]
        [Range(1, 1000,ErrorMessage =" A quantidae de vagas esta entr 1 e 1000")]
        public int QuantidadeVagas { get; set; }

        [Required(ErrorMessage ="Valor do ingresso maior ou igual a zero")]
        [Range(0,10000,ErrorMessage = "Valor do ingresso e maior que zero" )]
        public decimal ValorIngresso { get; set; }
    }
}