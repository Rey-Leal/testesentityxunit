using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityMVC.Models
{
    public class Produto
    {
        [Key, Display(Name = "Id")]
        public int id { get; set; }

        [ForeignKey("Grupo"), Display(Name = "Grupo")]
        public int grupoId { get; set; }

        [Required, StringLength(50), Display(Name = "Nome")]
        public string nome { get; set; }

        [Required, StringLength(250), Display(Name = "Especificação")]
        public string especificacao { get; set; }

        [Required, StringLength(20), Display(Name = "Unidade")]
        public string unidade { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true), Display(Name = "Preço")]
        public decimal preco { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true), Display(Name = "Quantidade")]
        public decimal quantidade { get; set; }

        public virtual Grupo? grupo { get; set; } = null!; // Referência de navegação do pai
    }
}