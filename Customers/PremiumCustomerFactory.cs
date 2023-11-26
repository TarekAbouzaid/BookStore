namespace BookStore.Customers;

public class PremiumCustomerFactory : ICustomerFactory
{
    public Customer Create()
    {
        return new PremiumCustomer();
    }
}