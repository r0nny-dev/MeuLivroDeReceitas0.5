using FluentMigrator;

namespace MeuLivroDeReceitas.Infrastructure.Versoes;

public class Versao000001 : Migration
{
    public override void Down()
    {
        throw new NotImplementedException();
    }

    public override void Up()
    {
        var tabela = Create.Table("Usuario");

        tabela
            .WithColumn("id").AsInt64().PrimaryKey().Identity()
            .WithColumn("DataCriacao").AsDateTime().NotNullable()
            .WithColumn("Nome").AsString(100).NotNullable()
            .WithColumn("Email").AsString().NotNullable()
            .WithColumn("Senha").AsString(2000).NotNullable()
            .WithColumn("Telefone").AsString(14).NotNullable();
    }
}
