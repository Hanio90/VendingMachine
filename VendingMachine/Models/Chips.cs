using System;
namespace VendingMachine.Models
{
    public class Chips: IProducts
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Chips()
        {
            Name = "Cheetos";
            Price = 0.50;
            Quantity = new Random().Next(1, 5);
        }
    }
}
