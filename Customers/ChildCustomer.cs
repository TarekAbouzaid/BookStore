namespace BookStore.Customers;

public class ChildCustomer : Customer
{
    //this customer is a child, so there is a maximum amount of books they can acquire per month
    public int MaximumBooksPerMonth { get; set; }
    
    public override void PrintCustomerInfo()
    {
        base.PrintCustomerInfo();
        Console.WriteLine("Amount of purchasable books remaining: " + MaximumBooksPerMonth);
    }
}