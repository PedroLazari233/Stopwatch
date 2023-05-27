namespace Stopwatch
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            while (true)
            {
                try
                {
                    Console.WriteLine("S to start, E to end and I for the interval");
                    var input = Console.ReadLine();

                    if (input == "S")
                    {
                        stopwatch.StartWatch();
                        Console.WriteLine("Wacth staterd at: " + stopwatch.StartTime);
                    }
                    else if (input == "E")
                    {
                        stopwatch.StopWatch();
                        Console.WriteLine("Wacth stopped at: " + stopwatch.EndTime);
                    }
                    else if (input == "I")
                    {
                        if (stopwatch.EndTime < stopwatch.StartTime)
                        {
                            Console.WriteLine("Insert the end time before asking for the interval");
                        }
                        else
                        {
                            stopwatch.ProvidePeriod();
                            Console.WriteLine(String.Format("{0}", stopwatch.Interval));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong input");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
        }
    }
}
