using NHibernate;
using FuncionarioWeb.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace FuncionarioWeb.Context.Map;

public class FuncionarioMap : ClassMapping<Funcionario>
{
    public FuncionarioMap()
    {
        Id(x => x.Id, x =>
        {
            x.Generator(Generators.Increment);
            x.Type(NHibernateUtil.Int32);
            x.Column("Id");
        });
        Property(b => b.Nome, b =>
        {
            b.Length(100);
            b.Type(NHibernateUtil.String);
            b.NotNullable(true);
        });
        Property(b => b.Idade, b =>
        {
            b.Type(NHibernateUtil.Int32);
            b.NotNullable(true);
        });
        Property(b => b.Salario, x =>
        {
            x.Type(NHibernateUtil.Double);
            x.Scale(2);
            x.Precision(10);
            x.NotNullable(true);
        });
        Table("Funcionarios");
    }
}
