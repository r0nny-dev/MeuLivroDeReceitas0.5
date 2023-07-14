using FluentMigrator.Builders.Create.Table;

namespace MeuLivroDeReceitas.Infrastructure.Migrations;

public static class VersaoBase
{
    public static ICreateTableColumnOptionOrWithColumnSyntax InserirColunasPadrao(ICreateTableWithColumnOrSchemaOrDescriptionSyntax table)
        => table
                .WithColumn("id").AsInt64().PrimaryKey().Identity()
                .WithColumn("DataCriacao").AsDateTime().NotNullable();
}
