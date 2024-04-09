using BenchmarkDotNet.Running;
using Domain.Models;

namespace benchmark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var summary = BenchmarkRunner.Run<Benchmark>();
            var summary = BenchmarkRunner.Run<ApiBenchmark>();
        }
    }
}
