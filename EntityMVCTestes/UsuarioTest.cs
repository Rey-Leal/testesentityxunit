using EntityMVC.Models;

namespace EntityMVCTestes
{
    public class UsuarioTest
    {        
        [Fact]
        public void Construtor_Atributos_DeveTerValoresPadrao()
        {
            // Arrange & Act
            var _usuario = new Usuario();

            // Assert
            Assert.Equal(0, _usuario.Id); // Padrão 0
            Assert.Null(_usuario.Nome);
            Assert.Null(_usuario.Senha);
            Assert.Null(_usuario.Email);
            Assert.Equal(default(DateTime), _usuario.DataCadastro);
        }

        [Fact]
        public void Setters_Atributos_PermiteAtribuicaoDeValores()
        {
            // Arrange
            var _usuario = new Usuario
            {
                Id = 1,
                Nome = "Nome do Usuario",
                Senha = "Senha",
                Email = "Email@exemplo.com",
                DataCadastro = DateTime.Now
            };

            // Assert
            Assert.Equal(1, _usuario.Id);
            Assert.Equal("Nome do Usuario", _usuario.Nome);
            Assert.Equal("Senha", _usuario.Senha);
            Assert.Equal("Email@exemplo.com", _usuario.Email);
            Assert.Equal(DateTime.Today, _usuario.DataCadastro.Date);
        }

        [Fact]
        public void Email_TamanhoMaiorQue50_DeveLancarException()
        {
            // Arrange
            var _usuario = new Usuario();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _usuario.Email = "123456789012345678901234567890123456789012345678901");
        }

        [Fact]
        public void Senha_TamanhoMaiorQue30_DeveLancarException()
        {
            // Arrange
            var _usuario = new Usuario();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _usuario.Senha = "1234567890123456789012345678901");
        }

        [Theory]
        [InlineData("usuario@exemplo.com", true)]
        [InlineData("usuario#exemplo.com", false)]
        [InlineData("usuario.com", false)]
        public void ValIdarEmail_DeveRetornarResultadosEsperados(string Email, bool resultadoEsperado)
        {
            // Arrange
            var _usuario = new Usuario(1, "Teste", "Senha123", Email);

            // Act
            bool resultado = _usuario.ValidarEmail();

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

    }
}