using System;

class Saledetails
{
    public int Salesno;
    public int Productno;
    public int Price;
    public string Dateofsale;
    public int Qty;
    public int TotalAmount;

    public Saledetails(int SalesNumber, int ProductNumber, int ProductPrice, int Quantity, string SaleDate)
    {
        Salesno = SalesNumber;
        Productno = ProductNumber;
        Price = ProductPrice;
        Qty = Quantity;
        Dateofsale = SaleDate;
    }

    public void Sales()
    {
        TotalAmount = Qty * Price;
    }

    public void ShowData()
    {
        Console.WriteLine("Sales Number: " + Salesno);
        Console.WriteLine("Product Number: " + Productno);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Quantity: " + Qty);
        Console.WriteLine("Date of Sale: " + Dateofsale);
        Console.WriteLine("Total Amount: " + TotalAmount);
    }

    static void Main()
    {
        Saledetails Sale = new Saledetails(101, 2001, 150, 4, "25-06-2025");
        Sale.Sales();
        Sale.ShowData();
        Console.ReadLine();
    }
}
