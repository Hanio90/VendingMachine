using System;
namespace VendingMachine.Models
{
    public class Candy:IProducts
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
		

        public Candy()
        {
            Name = "Snickers";
            Price = 0.65;
            Quantity = new Random().Next(1, 5);
        }
    }
}
