
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityMVC.Models
{
    public class Usuario
    {
        public Usuario() { }
        public Usuario(int id, string nome, string senha, string email)
        {
            this.id = id;
            this.nome = nome;
            this.senha = senha;
            this.email = email;
            this.dataCadastro = DateTime.Now;
        }

        [Key, Display(Name = "Id")]
        public int id { get; set; }

        private string _nome;
        [Required, StringLength(50), Display(Name = "Nome")]
        public string nome
        {
            get => _nome;
            set
            {
                if (value.Length <= 50)
                {
                    _nome = value;
                }
                else
                {
                    throw new ArgumentException("Nome maior que o permitido!");
                }
            }
        }

        private string _senha;
        [Required, StringLength(30), Display(Name = "Senha")]
        public string senha
        {
            get => _senha;
            set
            {
                if (value == null || value.Length <= 30)
                {
                    _senha = value;
                }
                else
                {
                    throw new ArgumentException("Senha maior que o permitido!");
                }
            }
        }

        private string _email;
        [Required, StringLength(50), Display(Name = "Login")]
        public string email
        {
            get => _email;
            set
            {
                if (value == null || value.Length <= 50)
                {
                    _email = value;
                }
                else
                {
                    throw new ArgumentException("Email maior que o permitido!");
                }
            }
        }

        [Display(Name = "Data de Cadastro")]
        public DateTime dataCadastro { get; set; }

        public bool ValidarEmail()
        {
            return email.Contains("@");
        }
    }
}