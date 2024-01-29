namespace ConsoleApp
{
    internal partial class Program
    {
        public class Log
        {
            public static void ToDatabase(object sender, OrderEventArgs e)
            {
                Console.WriteLine($"Order {e.OrderId} logged to database");
            }
        }
    }
}
