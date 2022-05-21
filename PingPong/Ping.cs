namespace PingPong
{
    public class Ping
    {
        public Pong Partner { get; set; }

        public delegate void PingEvent();
        public event PingEvent SendPing;

        Random _rnd;

        public Ping()
        {
            _rnd = new();
        }

        public void OnPong()
        {
            if (_rnd.Next(0, 10) > 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ping recived Pong...");
                Console.ResetColor();
                SendPing?.Invoke();
            }
            else
            {
                Program.continuePlay = false;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ping loose!");
                Console.ResetColor();
            }
        }

        public void AddPong(Pong pong)
        {
            pong.SendPong += OnPong;
        }
    }
}
