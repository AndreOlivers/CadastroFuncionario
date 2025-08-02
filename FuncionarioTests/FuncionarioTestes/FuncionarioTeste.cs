using FuncionarioWeb.Entities;

namespace SeuProjeto.Tests
{
    public class FuncionarioTests
    {
        [Fact]
        public void Deve_CriarFuncionario_ComDadosCorretos()
        {
            // Arrange
            //int id = 1;
            string nome = "João";
            int idade = 30;
            double salario = 2500.50;

            // Act
            var funcionario = new Funcionario(nome, idade, salario);

            // Assert
            //Assert.Equal(id, funcionario.Id);
            Assert.Equal(nome, funcionario.Nome);
            Assert.Equal(idade, funcionario.Idade);
            Assert.Equal(salario, funcionario.Salario);
        }

        [Theory]
        [InlineData(1, "Ana", 28, 3000.00)]
        [InlineData(2, "Carlos", 40, 4500.75)]
        public void Deve_CriarFuncionario_UsandoDadosVariados(int id, string nome, int idade, double salario)
        {
            // Act
            var funcionario = new Funcionario(nome, idade, salario);

            // Assert
            //Assert.Equal(id, funcionario.Id);
            Assert.Equal(nome, funcionario.Nome);
            Assert.Equal(idade, funcionario.Idade);
            Assert.Equal(salario, funcionario.Salario);
        }
    }
}
