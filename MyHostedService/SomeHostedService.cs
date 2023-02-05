namespace MyHostedService
{
    public class SomeHostedService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while(!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    //some work
                    await Task.Delay(1000);
                }
                catch (OperationCanceledException)
                {
                    //maintain error
                }

                await Task.Delay(1000);
            }
        }
    }
}
