namespace AsyncDemoCloud;

public class ParallelCounter
{
    private int _counter = 0;

    public void Start()
    {
        var up = new Thread(CountUp);
        up.Name = "up";
        var down = new Thread(CountDown);
        down.Name = "down";

        Console.WriteLine("Start");
        up.Start();
        down.Start();
        Console.WriteLine("Done");
    }

    private void CountUp()
    {
        Console.WriteLine("Startar CountUp");
        var currentThread = Thread.CurrentThread;
        for (int i = 0; i < 10; i++)
        {
            _counter++;
            Thread.Sleep(100);
            Console.WriteLine($"Thread: {currentThread.Name} is at {_counter}");
        }
    }

    private void CountDown()
    {
        Console.WriteLine("Startar CountDown");
        var currentThread = Thread.CurrentThread;
        for (int i = 9; i >= 0; i--)
        {
            _counter--;
            Thread.Sleep(100);
            Console.WriteLine($"Thread: {currentThread.Name} is at {_counter}");
        }
    }
}