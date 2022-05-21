namespace Counter
{
    public class Counter
    {
        public delegate void CountDone();
        public event CountDone Done;

        int _maxcount;
        public Counter(int maxcount)
        {
            _maxcount = maxcount;
        }

        public void StartCount()
        {
            Console.WriteLine("Start...");

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"{i}");

                if (i == _maxcount)
                {
                    Done?.Invoke();
                    break;
                }
            }
        }
    }
}
