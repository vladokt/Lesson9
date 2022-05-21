namespace Counter
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.Write("Count to (1-100): ");
            int count = int.Parse(Console.ReadLine());

            Counter counter = new(count);

            Handler1 handler1 = new(counter);
            Handler2 handler2 = new(counter);

            counter.StartCount();

            Console.WriteLine("Bye!");
            Console.ReadLine();
        }
    }
}