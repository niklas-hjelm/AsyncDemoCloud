namespace AsyncDemoCloud;

public class Counter
{
    public void Start()
    {
        Console.WriteLine("Start");
        CountUp();
        CountDown();
        Console.WriteLine("Done");
    }

    private void CountUp()
    {
        Console.WriteLine("Startar CountUp");
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(100);
            Console.WriteLine(i);
        }
    }

    private void CountDown()
    {
        Console.WriteLine("Startar CountDown");
        for (int i = 9; i >= 0; i--)
        {
            Thread.Sleep(100);
            Console.WriteLine(i);
        }
    }
}