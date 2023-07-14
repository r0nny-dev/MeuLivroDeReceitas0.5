using Microsoft.Extensions.Configuration;

namespace MeuLivroDeReceitas.Domain.Extension;

public static class RepositorioExtension
{
    public static string GetNomeDatabase(this IConfiguration configurationManager)
    {
        var nomeDatabase = configurationManager.GetConnectionString("NomeDatabase");

        return nomeDatabase;
    }

    public static string GetConexaoDatabase(this IConfiguration configurationManager)
    {
        var connectionString = configurationManager.GetConnectionString("Conexao");

        return connectionString;
    }

    public static string GetConexaoCompleta(this IConfiguration configurationManager)
    {
        var nomeDatabase = configurationManager.GetNomeDatabase();
        var conexao = configurationManager.GetConexaoDatabase();

        return $"{conexao}Database={nomeDatabase}";
    }
}
