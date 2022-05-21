namespace Strings
{
    public class FoundEventArgs : EventArgs
    {
        public string FoundedString { get; set; }
        public int Position { get; set; }

        public FoundEventArgs(string foundedString, int position)
        {
            FoundedString = foundedString;
            Position = position;
        }
    }
}
