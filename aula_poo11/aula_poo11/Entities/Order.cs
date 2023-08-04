using System;
using aula_poo11.Entities.Enums;

namespace aula_poo11.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id + ", " 
                + Moment + ", " 
                + Status;
        }
    }
}
