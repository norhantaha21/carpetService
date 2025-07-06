namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estimate for carpet cleaning service ");
            Console.WriteLine("Numbers of small carpets :");
            int smallCarpets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numbers of large carpets :");
            int largeCarpets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Price per small carpet : 25$");
            Console.WriteLine("Price per large carpet : 35$");

            int cost = (smallCarpets * 25) + (largeCarpets * 35);
            Console.WriteLine($"Cost : ${cost}");

            double tax = (cost * 0.06);
            Console.WriteLine($"Tax : ${tax}");

            double totalEstimates = (cost + tax);
            Console.WriteLine("==================================================");
            Console.WriteLine($"Total estimates : ${totalEstimates}");

            Console.WriteLine("This estimate is valid for 30 days ");
        }
    }
}
