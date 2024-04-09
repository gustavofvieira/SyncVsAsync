using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

public class BenchmarkTest
{
    private Database _database;

    [GlobalSetup]
    public void Setup()
    {
        // Aqui você pode inicializar seu banco de dados antes de executar os testes
        _database = new Database();
    }

    [Benchmark]
    public void TestMethod()
    {
        // Aqui você pode realizar operações no banco de dados para medir o desempenho
        _database.Query();
    }

    // Classe simulando um banco de dados simples para fins de exemplo
    public class Database
    {
        public void Query()
        {
            // Simulação de uma operação de consulta no banco de dados
            // Aqui você pode adicionar a lógica real do banco de dados
            // Este é apenas um exemplo simulado
            Console.WriteLine("Executando consulta no banco de dados...");
        }
    }
}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        var summary = BenchmarkRunner.Run<BenchmarkTest>();
//    }
//}
