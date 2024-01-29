namespace ConsoleApp
{
    internal partial class Program
    {
        public class Order
        {
            public event EventHandler<OrderEventArgs> OnCreated;

            public void CreateOrder(int OrderId, string Customer)
            {
                Console.WriteLine("Order created");
                OnCreated?.Invoke(this, new OrderEventArgs { OrderId = OrderId, Customer = Customer });
            }
        }
    }
}
