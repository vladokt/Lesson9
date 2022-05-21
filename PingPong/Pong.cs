namespace PingPong
{
    public class Pong
    {
        public Ping Partner { get; set; }

        public delegate void PongEvent();
        public event PongEvent SendPong;

        Random _rnd;

        public Pong()
        {
            _rnd = new();
        }

        public void OnPing()
        {
            if (_rnd.Next(0, 10) > 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pong recived Ping...");
                Console.ResetColor();
                SendPong?.Invoke();
            }
            else
            {
                Program.continuePlay = false;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Pong loose!");
                Console.ResetColor();
            }
        }

        public void AddPing(Ping ping)
        {
            ping.SendPing += OnPing;
        }
    }
}
