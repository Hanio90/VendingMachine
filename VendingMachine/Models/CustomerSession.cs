using System;
using System.Collections.Generic;

namespace VendingMachine.Models
{
    public class CustomerSession
    {
        public List<IProducts> Inventory { get; set; }
        public double Wallet { get; set; }
        public double Change { get; set; }


        public CustomerSession()
        {
            Wallet = 0;
            Change = 0;

            //Filling the list in one line
            Inventory = new List<IProducts>()
            {
                new Cola(),
                new Candy(),
                new Chips()

            };

            //This is the older way of doing it!

            //Cola cola = new Cola();
            //Candy candy = new Candy();
            //Chips chips = new Chips();

            //Inventory.Add(cola);
            //Inventory.Add(candy);
            //Inventory.Add(chips);
        }

    }
}
