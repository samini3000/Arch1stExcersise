using Arch1stExcersise;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using Perfolizer.Horology;

namespace Benchmark
{
    public class Config : ManualConfig
    {
        public Config()
        {
            AddJob(
                Job.Default
                    .WithIterationTime(TimeInterval.FromSeconds(4))
            );
        }
    }

    [MemoryDiagnoser]
    [Config(typeof(Config))]
    public class ReportBenchmark
    {
        private  IPerfomanceTestingService _perfomanceTestingService;


        [GlobalSetup]
        public void Setup()
        {
            _perfomanceTestingService = new PerfomanceTestingService();
        }


        [Benchmark]
        public async Task AsyncGetReport()
        {
            await _perfomanceTestingService.AsyncTask();
        }

        [Benchmark]
        public void BadAsyncGetReport()
        {
            _perfomanceTestingService.BadAsynctask();
        }

        [Benchmark]
        public void SyncGetReport()
        {
            _perfomanceTestingService.SyncThread();
        }

    }
}
