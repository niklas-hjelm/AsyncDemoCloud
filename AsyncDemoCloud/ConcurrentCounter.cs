namespace AsyncDemoCloud;

public class ConcurrentCounter
{
    public void Start()
    {
        Console.WriteLine("Start");
        CountUp();
        CountDown();
        Console.WriteLine("Done");
    }

    private async Task CountUp()
    {
        await Task.Run(() =>
        {
            var currentThread = Thread.CurrentThread;
            Console.WriteLine("Startar CountUp");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);

                Console.WriteLine($"Thread: {currentThread.Name} is at {i}");
            }
        });
    }

    private async Task CountDown()
    {
        await Task.Run(() =>
        {
            var currentThread = Thread.CurrentThread;
            Console.WriteLine("Startar CountDown");
            for (int i = 9; i >= 0; i--)
            {
                Thread.Sleep(200);
                Console.WriteLine($"Thread: {currentThread.Name} is at {i}");
            }
        });
    }
}