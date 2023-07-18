using Microsoft.Extensions.Configuration;

namespace MeuLivroDeReceitas.Domain.Extension;

public static class RepositorioExtension
{
    public static string GetNomeDatabase(this IConfiguration configurationManager)
        => configurationManager.GetConnectionString("NomeDataBase");

    public static string GetConexao(this IConfiguration configurationManager)
        => configurationManager.GetConnectionString("Conexao");

    public static string GetConexaoCompleta(this IConfiguration configurationManager)
    {
        var nomeDatabase = configurationManager.GetNomeDatabase();
        var conexao = configurationManager.GetConexao();

        return $"{conexao}Database={nomeDatabase};";
    }
}
