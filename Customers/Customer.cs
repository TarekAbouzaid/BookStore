namespace BookStore.Customers;

public abstract class Customer
{
    public int id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string emailAddress { get; set; }

    public virtual void PrintCustomerInfo()
    {
        Console.WriteLine("Customer id: " + id + "\nFirst name: " + firstName + "\nLast name: " + lastName + "\nE-Mail Address: " + emailAddress);
    }
}