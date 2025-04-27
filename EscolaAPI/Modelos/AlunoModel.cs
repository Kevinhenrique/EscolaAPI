using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaAPI.Modelos
{
    public class AlunoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo CPF é obrigatório")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Campo de Data Nascimento é obrigatório")]
        public DateTime Data_Nascimento { get; set; }
        [Required(ErrorMessage = "Campo E-mail é obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo Sexo é obrigatório")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "Campo Telefone é obrigatório")]
        public string Telefone { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public string? Rua { get; set; }
        public string? Complemento { get; set; }
        public string? Estado { get; set; }
        public string? Cidade { get; set; }
        [Required(ErrorMessage = "Campo da Turma é obrigatório")]
        public int Id_Classe { get; set; } 
    }
}
