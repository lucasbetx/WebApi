using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApi.Models.Entities
{
    [Table("Livros")]
    public class Livro
    {
        [Key]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório.")]
        [MaxLength(200, ErrorMessage = "O nome não pode ultrapassar 200 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Necessario informar a edição desse livro")]
        public string Edicao { get; set; }

        [Range(1, Int32.MaxValue, ErrorMessage = "O numero de pagina deve estar entre {1} e {2}")]
        public int NumeroPagina { get; set; }
        
        public decimal Preco { get; set; }

        [Url(ErrorMessage = "Esse campo necessita de uma url valida.")]
        public string SiteLivro { get; set; }

        [EmailAddress(ErrorMessage = "Necessario um e-mail valido.")]
        public string EmailAutor { get; set; }

        [ForeignKey("Editora")]
        public Guid CodigoEditora { get; set; }

        [JsonIgnore]
        public virtual Editora Editora { get; set; }
    }
}