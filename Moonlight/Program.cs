namespace FirePortal
{
    public class Program
    {
        private static readonly Startup Startup = new();
        
        public static async Task Main(string[] args)
        {
            StartOfMain:
            Console.WriteLine("FirePortal");
            Console.WriteLine($"Copyright {DateTime.UtcNow.Year} Raphael Raberger");
            Console.WriteLine($"Inspired by the Moonlight Panel Project!");
            Console.WriteLine();

            try
            {
                await Startup.Init(args);
            }
            catch (Exception ex)
            {
                Console.WriteLine("High level error: \n" + ex);
                Console.Clear();
                goto StartOfMain;
            }
            await Startup.Start();
        }
    }
}