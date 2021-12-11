using System;

namespace Napilnik1
{
    public sealed class Order
    {
        public string Paylink { get; }

        public Order() => Paylink = $"\n{Guid.NewGuid().ToString()}";
    }
}