using Benchmark;
using BenchmarkDotNet.Running;

namespace Benchmarks;

public class Program
{
    public static void Main(string[] args)
    {
        //what is this project goal
        /*  | Approach              | Thread Blocked? | Scalable? | Memory Usage | High Concurrency |
            | --------------------- | --------------- | --------- | ------------ | ---------------- |
            | Thread.Sleep          | YES             | Poor      | High         | Bad              |
            | `.Wait()` / `.Result` | YES             | Poor      | High         | Bad              |
            | `await`               | NO              | Excellent | Low          | Excellent        |
        */

        //benchmark output
        /*| Method            | Mean       | Error    | StdDev   | Allocated |
        |------------------ |-----------:|---------:|---------:|----------:|
        | AsyncGetReport    |   618.7 ms |  1.77 ms |  1.57 ms |    1944 B |
        | BadAsyncGetReport | 6,260.4 ms | 37.96 ms | 35.51 ms |   23200 B |
        | SyncGetReport     | 6,236.7 ms |  8.58 ms |  8.02 ms |         - |
        */
        BenchmarkRunner.Run<ReportBenchmark>();
    }
}
