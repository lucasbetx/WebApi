using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApi.Models.Entities
{
    [Table("Editoras")]
    public class Editora
    {
        public Editora()
        {
            Livros = new List<Livro>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório.")]
        [MaxLength(200, ErrorMessage = "O nome da Editora não pode ultrapassar {1} caracteres.")]
        [MinLength(3, ErrorMessage = "O nome da Editora não pode ter menos de {1} caracteres.")]
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        [Url(ErrorMessage = "Esse campo necessita de uma url válida.")]
        public string Site { get; set; }
        [EmailAddress(ErrorMessage = "Necessário um e-mail válido.")]
        public string EmailContato { get; set; }
        public string Observacao { get; set; }
        
        public virtual ICollection<Livro> Livros { get; set; }
    }
}