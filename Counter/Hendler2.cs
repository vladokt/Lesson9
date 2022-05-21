namespace Counter
{
    public class Handler2
    {
        Counter _counter;
        public Handler2(Counter counter)
        {
            _counter = counter;
            _counter.Done += Complete;
        }

        public void Complete()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Hendler2: The end complete.");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}