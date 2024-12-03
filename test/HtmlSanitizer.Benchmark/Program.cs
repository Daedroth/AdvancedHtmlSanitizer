using Ahs.Benchmark;
using BenchmarkDotNet.Running;

BenchmarkSwitcher.FromAssembly(typeof(HtmlSanitizerBenchmark).Assembly).Run(args);