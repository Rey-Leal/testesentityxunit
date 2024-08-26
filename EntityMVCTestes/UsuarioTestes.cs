using EntityMVC.Models;

namespace EntityMVCTestes
{
    public class UsuarioTestes
    {        
        [Fact]
        public void Construtor_Atributos_DeveTerValoresPadrao()
        {
            // Arrange & Act
            var _usuario = new Usuario();

            // Assert
            Assert.Equal(0, _usuario.id); // Padrão 0
            Assert.Null(_usuario.nome);
            Assert.Null(_usuario.senha);
            Assert.Null(_usuario.email);
            Assert.Equal(default(DateTime), _usuario.dataCadastro);
        }

        [Fact]
        public void Setters_Atributos_PermiteAtribuicaoDeValores()
        {
            // Arrange
            var _usuario = new Usuario
            {
                id = 1,
                nome = "Nome do Usuario",
                senha = "senha",
                email = "email@exemplo.com",
                dataCadastro = DateTime.Now
            };

            // Assert
            Assert.Equal(1, _usuario.id);
            Assert.Equal("Nome do Usuario", _usuario.nome);
            Assert.Equal("senha", _usuario.senha);
            Assert.Equal("email@exemplo.com", _usuario.email);
            Assert.Equal(DateTime.Today, _usuario.dataCadastro.Date);
        }

        [Fact]
        public void Email_TamanhoMaiorQue50_DeveLancarException()
        {
            // Arrange
            var usuario = new Usuario();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => usuario.email = "123456789012345678901234567890123456789012345678901");
        }

        [Fact]
        public void Senha_TamanhoMaiorQue30_DeveLancarException()
        {
            // Arrange
            var usuario = new Usuario();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => usuario.senha = "1234567890123456789012345678901");
        }

        [Theory]
        [InlineData("usuario@exemplo.com", true)]
        [InlineData("usuario#exemplo.com", false)]
        [InlineData("usuario.com", false)]
        public void ValidarEmail_DeveRetornarResultadosEsperados(string email, bool resultadoEsperado)
        {
            // Arrange
            var usuario = new Usuario(1, "Teste", "Senha123", email);

            // Act
            bool resultado = usuario.ValidarEmail();

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

    }
}