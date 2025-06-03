namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> lookup = new Dictionary<int, string>();
            //Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            //Dictionary<DateTime, string> keyValuePairs1 = new Dictionary<DateTime, string>();
            //Dictionary<DateOnly, string> keyValuePairs2 = new Dictionary<DateOnly, string>();
            //Dictionary<bool, string> keyValuePairs3 = new Dictionary<bool, string>();
            //Dictionary<double, string> keyValuePairs4 = new Dictionary<double, string>();
            //Dictionary<string, string> fish = new Dictionary<string, string>();
            //fish["shark"] = "Ahhhhhhhh!";
            //fish["catfish"] = "oh";
            //string answer = Console.ReadLine();
            //Console.WriteLine(fish[answer]);
            Console.WriteLine("Please enter key: ");
            string key = Console.ReadLine();
            Console.WriteLine("Write Value");
            string value = Console.ReadLine();
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add(key, value);
            Console.WriteLine($"Key/Value is {keyValuePairs}");
        }
    }
}
