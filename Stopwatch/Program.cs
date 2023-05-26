namespace Stopwatch
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            while (true)
            {
                Console.WriteLine("S to start, E to end and I for the interval");
                var input = Console.ReadLine();

                if(input == "S")
                {
                    stopwatch.StartWatch();
                    Console.WriteLine(stopwatch.StartTime);
                }
                else if(input == "E")
                {
                    stopwatch.StopWatch();
                    Console.WriteLine(stopwatch.EndTime);
                }
                else if(input == "I")
                {
                    stopwatch.ProvidePeriod();
                    Console.WriteLine(String.Format("{0}", stopwatch.Interval));
                }
                else
                {
                    Console.WriteLine("Wrong input");
                    Console.WriteLine("S to start, E to end and P for the period");
                }
            }
        }
    }
}
