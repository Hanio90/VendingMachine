using System;
namespace VendingMachine.Models
{
    public interface IProducts
    {

        string Name { get; set; }

        double Price { get; set; }

        int Quantity { get; set; }

    }
}
