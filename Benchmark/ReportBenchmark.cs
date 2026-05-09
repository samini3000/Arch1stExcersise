using Arch1stExcersise;
using BenchmarkDotNet.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace Benchmark
{


    [MemoryDiagnoser]
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
