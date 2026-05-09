namespace Arch1stExcersise
{
    public class PerfomanceTestingService : IPerfomanceTestingService
    {
        public async Task AsyncTask()
        {
            for (var i = 0; i < 10; i++)
                await Task.Delay(50);
        }

        public void BadAsynctask()
        {
            for (var i = 0; i < 100; i++)
                Task.Delay(50).Wait();
        }

        public void SyncThread()
        {
            for (var i = 0; i < 100; i++)
                Thread.Sleep(50);
        }
    }
}
