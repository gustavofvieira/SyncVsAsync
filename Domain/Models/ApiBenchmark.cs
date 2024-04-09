using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Net.Http;
using System.Threading.Tasks;

[RankColumn]
[MemoryDiagnoser]
public class ApiBenchmark
{
    private HttpClient _httpClient;

    [GlobalSetup]
    public void Setup()
    {
        // Configure seu HttpClient aqui, se necessário
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("https://localhost:44375/benchmark/");
    }

    [Benchmark]
    public async Task ExecuteApiRequestSync()
    {
        // Execute uma solicitação à sua API e meça o desempenho
        HttpResponseMessage response = await _httpClient.GetAsync("consume-sync");
        response.EnsureSuccessStatusCode();

        // Você pode opcionalmente ler e processar o conteúdo da resposta aqui
        // Exemplo: string content = await response.Content.ReadAsStringAsync();
    }
    [Benchmark]
    public async Task ExecuteApiRequestAsync()
    {
        // Execute uma solicitação à sua API e meça o desempenho
        HttpResponseMessage response = await _httpClient.GetAsync("consume-async");
        response.EnsureSuccessStatusCode();

        // Você pode opcionalmente ler e processar o conteúdo da resposta aqui
        // Exemplo: string content = await response.Content.ReadAsStringAsync();
    }
}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        // Execute o teste de benchmark e obtenha o resumo dos resultados
//        var summary = BenchmarkRunner.Run<ApiBenchmark>();
//    }
//}
