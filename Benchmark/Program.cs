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
        BenchmarkRunner.Run<ReportBenchmark>();
    }
}
