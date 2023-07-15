using Microsoft.Extensions.Configuration;

namespace MeuLivroDeReceitas.Domain.Extension;

public static class RepositorioExtension
{
    public static string GetNomeDatabase(this IConfiguration configurationManager)
        => configurationManager.GetConnectionString("NomeDatabase");

    public static string GetConexaoDatabase(this IConfiguration configurationManager)
        => configurationManager.GetConnectionString("Conexao");
}
