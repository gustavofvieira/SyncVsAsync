using BenchmarkDotNet.Attributes;
using Domain.Data;
using System.Threading.Tasks;

namespace Domain.Models
{

    [RankColumn]
    [MemoryDiagnoser]
    public class Benchmark
    {
        [Benchmark]
        public void CallSync()
        {
            var consume = new ConsumeDataSync();
            var file2 = "C://Users//gusta//OneDrive//Documentos//Github//sync-async//Domain//Data//thousand.json";
            consume.Execute(file2);
        }

        [Benchmark]
        public async Task CallAsync()
        {
            var consume = new ConsumeData();
            var file2 = "C://Users//gusta//OneDrive//Documentos//Github//sync-async//Domain//Data//thousand.json";
            await consume.Execute(file2);
        }
    }
}
