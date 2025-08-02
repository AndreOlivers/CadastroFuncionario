using Microsoft.AspNetCore.Components.Web.Virtualization;

namespace FuncionarioWeb.Entities;

public class Funcionario
{
    #region PROPRIEDADES
    public virtual int Id { get; protected set; }
    public virtual string? Nome { get; protected set; }
    public virtual int Idade { get; protected set; }
    public virtual double Salario { get; protected set; }
    #endregion

    #region CONSTRUTORES
    public Funcionario() : base() { }

    public Funcionario(string nome, int idade, double salario) 
        : base() 
    {
        SetNome(nome);
        SetIdade(idade);
        SetSalario(salario);
    }
    #endregion

    #region METODOS SET'S
    private void SetNome(string nome)
    {
        Nome = nome;
    }

    private void SetIdade(int idade)
    {
        Idade = idade;
    }

    private void SetSalario(double salario)
    {
        Salario = salario;
    }

    #endregion


}
