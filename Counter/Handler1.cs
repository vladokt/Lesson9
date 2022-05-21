namespace Counter
{
    public class Handler1
    {
        Counter _counter;
        public Handler1(Counter counter)
        {
            _counter = counter;
            _counter.Done += Complete;
        }

        public void Complete()
        {
            Console.ForegroundColor=ConsoleColor.Red;
            Console.Write("Hendler1: Done!");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
