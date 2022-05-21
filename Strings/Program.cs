namespace Strings
{
    public class Program
    {
        static StringSearcher stringSearcher;
        public static void Main()
        {
            List<string> strings = new List<string>() { "hjgkhghjk", "879065764", "ji987hok9", "oikjhgvfc", "675403439", "qwdxzasoi", "765432098" };
            string pattern;

            Console.Clear();
            Console.WriteLine("We have list:");
            for (int i = 0; i < strings.Count; i++)
            {
                Console.WriteLine($"{i + 1}. \"{strings[i]}\"");
            }
            
            Console.Write("What do you want to find? (1 - digits, 2 - letters): ");
            if (Console.ReadLine() == "1")
            {
                pattern = @"^\d+$";
                Console.WriteLine("We will find digits");
            }
            else
            {
                pattern = @"^[a-z]+$";
                Console.WriteLine("We will find letters");
            }

            Console.WriteLine("Let's find it.");

            stringSearcher = new();
            stringSearcher.Done += OnDone;

            stringSearcher.Search(strings, pattern);

            Console.WriteLine("That's all. Bye!");
        }

        static void OnDone(object obj, FoundEventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"The string \"{args.FoundedString}\" at position {args.Position} matches.");
            Console.ResetColor();
            
            Console.Write("Do you want to continue? (y/n): ");
            if (Console.ReadLine()=="n")
            {
                stringSearcher.Done -= OnDone;
            }
        }
    }
}