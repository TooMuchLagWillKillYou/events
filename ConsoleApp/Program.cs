namespace ConsoleApp
{
    internal partial class Program
    {
        // Remarks
        // Se in alcune occasioni volessi lanciare solamente un event handler 
        // tra Email.Send e Log.ToDatabase come potrei fare? Sono costretto a 
        // lanciarli entrambi?

        public static void Main()
        {
            var order = new Order();
            order.OnCreated += Email.SendEmail ? Email.Send : null;
            order.OnCreated += Log.ToDatabase;
            order.CreateOrder(1, "John Doe");
        }

        public delegate void EventHandler(object sender, OrderEventArgs e);
    }
}
