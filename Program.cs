namespace Hashtable_Day15
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome");

            Frequency frequency = new Frequency();

            //Console.WriteLine("Frequency of Words: ");

            //string str = "to be or not to be";
            //frequency.count_frequency(str);

            Console.WriteLine("Frequency of Words: ");

            string string2 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            frequency.count_frequency(string2);
        }
    }
}