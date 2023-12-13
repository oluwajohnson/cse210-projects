using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Order p1 = new Order();
        p1.TotalPriceInUsa(5);
        p1.TotalPriceOutSideUsa(5);

        Address address = new Address();
        address.InUsa("119 Orange road", "New York City", "New York", "USA");
        address.OutsideUsa("119 Apo Mechanic", "Abuja", "FCT", "Nigeria");


    }

}