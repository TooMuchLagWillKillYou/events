namespace ConsoleApp
{
    internal partial class Program
    {
        public class OrderEventArgs : EventArgs
        {
            public int OrderId { get; set; }
            public string Customer { get; set; } = string.Empty;
        }
    }
}
