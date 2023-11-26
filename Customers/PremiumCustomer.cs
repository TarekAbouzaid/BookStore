namespace BookStore.Customers;

public class PremiumCustomer : Customer
{
    //this customer has a premium subscription
    public int freeBooksPerMonth { get; set; }

    public override void PrintCustomerInfo()
    {
        base.PrintCustomerInfo();
        Console.WriteLine("Free books per month remaining: " + freeBooksPerMonth);
    }
    
}