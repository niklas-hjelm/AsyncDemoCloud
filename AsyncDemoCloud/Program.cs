using AsyncDemoCloud;

//var counter = new Counter();
var counter = new ConcurrentCounter();
//var counter = new ParallelCounter();

var currentThread = Thread.CurrentThread;

currentThread.Name = "main";

Console.WriteLine(currentThread.ManagedThreadId);

Thread.Sleep(1500);

counter.Start();

Console.ReadLine();