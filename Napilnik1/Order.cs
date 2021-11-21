using System;

namespace Napilnik1
{
    public class Order
    {
        public string Paylink => Guid.NewGuid().ToString();
    }
}
