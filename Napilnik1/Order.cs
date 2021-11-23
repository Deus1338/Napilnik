using System;

namespace Napilnik1
{
    public class Order
    {
        public string Paylink { get; }

        public Order()
        {
            Paylink = Guid.NewGuid().ToString();
        }
    }
}
