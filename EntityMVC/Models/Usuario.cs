
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestesEntityMVC.Models
{
    public class Usuario
    {
        [Key, Display(Name = "Id")]
        public int id { get; set; }
        [Required, StringLength(50), Display(Name = "Nome")]
        public string nome { get; set; }
        [Required, StringLength(30), Display(Name = "Senha")]
        public string senha { get; set; }
        [Required, StringLength(50), Display(Name = "Login")]
        public string email { get; set; }
        [Display(Name = "Data de Cadastro")]
        public DateTime dataCadastro { get; set; }
    }
}