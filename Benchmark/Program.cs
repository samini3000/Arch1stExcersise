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

        //run this command
        //
        //dotnet run -c Release
        //benchmark output  
        /*| Method            | Mean       | Error    | StdDev   | Allocated |
        /*---------------- |--------:|---------:|---------:|----------:|
        | AsyncGetReport    | 6.243 s | 0.0304 s | 0.0284 s |   17064 B |
        | BadAsyncGetReport | 6.242 s | 0.0568 s | 0.0531 s |   23200 B |
        | SyncGetReport     | 6.205 s | 0.0130 s | 0.0122 s |         - |*/
        BenchmarkRunner.Run<ReportBenchmark>();
    }
}
