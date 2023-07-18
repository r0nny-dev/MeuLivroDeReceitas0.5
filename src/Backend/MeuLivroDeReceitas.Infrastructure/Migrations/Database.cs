using Dapper;
using Npgsql;

namespace MeuLivroDeReceitas.Infrastructure.Migrations;

public static class Database
{
    public static void CriarDatabase(string connectionString, string nomeDatabase)
    {
        using var conn = new NpgsqlConnection(connectionString);

        var parametros = new DynamicParameters();

        parametros.Add("nome", nomeDatabase);

        var registros = conn.Query("SELECT * FROM pg_database WHERE datname = @nome", parametros);

        if (!registros.Any())
            conn.Execute($"CREATE DATABASE {nomeDatabase}");
    }
}
