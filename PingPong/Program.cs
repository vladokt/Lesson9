namespace PingPong
{
    public class Program
    {
        public static bool continuePlay = true;
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Let's play ping-pong!");
            Console.ReadLine();

            Ping ping = new();
            Pong pong = new();
            ping.Partner = pong;
            pong.Partner = ping;
            ping.AddPong(pong);
            pong.AddPing(ping);

            ping.OnPong();

            do
            {
            }
            while (continuePlay);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Game over!");
        }
    }
}