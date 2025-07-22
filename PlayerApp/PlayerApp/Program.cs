namespace PlayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player(101, "Rhea", 23);
            Player p2 = new Player(102, "Sanjana", 22);

            Player elder = p1.WhoisElder(p2);
            Console.WriteLine($"Elder Player: {elder.GetName()}, Age: {elder.GetAge()}");
        }
    }
}
