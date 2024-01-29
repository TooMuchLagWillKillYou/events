namespace ConsoleApp
{
    internal partial class Program
    {
        public class Email
        {
            public static bool SendEmail = true;

            public static void Send(object sender, OrderEventArgs e)
            {
                Console.WriteLine($"Email sent to {e.Customer}");
            }
        }
    }
}
