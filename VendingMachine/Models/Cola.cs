using System;
namespace VendingMachine.Models
{
    public class Cola: IProducts
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Cola()
        {
            Name = "CocaCola";
            Price = 1.00;
            Quantity = new Random().Next(1, 5);
        }
    }
}
