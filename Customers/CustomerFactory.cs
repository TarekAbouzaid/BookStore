using BookStore.Books;

namespace BookStore.Customers;

public class CustomerFactory
{
    public ICustomer Create(string firstName, string lastName, string emailAddress, CustomerType customerType)
    {
        return customerType switch
        {
            CustomerType.VIP => new VIPCustomer(firstName, lastName, emailAddress),
            CustomerType.Student => new StudentCustomer(firstName, lastName, emailAddress),
            _ => throw new ArgumentOutOfRangeException(nameof(customerType), customerType, null)
        };
    }
}