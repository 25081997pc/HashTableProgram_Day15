namespace Hashtable_Day15
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome");

            Frequency frequency = new Frequency();

            Console.WriteLine("Frequency of Words: ");
            string str = "to be or not to be";
            frequency.count_frequency(str);
           
        }
    }
}