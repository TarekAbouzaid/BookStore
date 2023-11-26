namespace BookStore.Customers;

public class ChildCustomerFactory : ICustomerFactory
{
    public Customer Create()
    {
        return new ChildCustomer();
    }
}