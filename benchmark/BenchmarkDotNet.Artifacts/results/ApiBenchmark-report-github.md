```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-11390H 3.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]     : .NET Core 3.1.32 (CoreCLR 4.700.22.55902, CoreFX 4.700.22.56512), X64 RyuJIT AVX2
  DefaultJob : .NET Core 3.1.32 (CoreCLR 4.700.22.55902, CoreFX 4.700.22.56512), X64 RyuJIT AVX2


```
| Method                 | Mean     | Error   | StdDev   | Rank | Allocated |
|----------------------- |---------:|--------:|---------:|-----:|----------:|
| ExecuteApiRequestSync  | 262.6 ms | 5.23 ms | 15.01 ms |    2 |  258.5 KB |
| ExecuteApiRequestAsync | 247.5 ms | 4.89 ms |  7.89 ms |    1 |    259 KB |
