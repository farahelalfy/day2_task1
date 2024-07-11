namespace day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("plz enter a num");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"the multplication for {num}");
            for (int i = 1; i < 12; i++)
            {
                Console.WriteLine($" {num}*{i}={i * num}");
            }
        }
    }
}
