namespace BookStore.Customers;

public class BasicCustomerFactory : ICustomerFactory
{
    public Customer Create()
    {
        return new BasicCustomer();
    }

}