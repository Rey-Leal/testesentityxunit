
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestesEntityMVC.Models
{
    public class Grupo
    {
        [Key, Display(Name = "Id")]
        public int id { get; set; }
        [Required, StringLength(50), Display(Name = "Descrição")]
        public string descricao { get; set; }
        [Required, StringLength(250), Display(Name = "Especificação")]
        public string especificacao { get; set; }
        [Required, StringLength(1), Display(Name = "Tipo")]
        public string tipo { get; set; }
        public virtual ICollection<Produto> produtos { get; set; } = new List<Produto>(); // Coleção de navegação filha
    }
}