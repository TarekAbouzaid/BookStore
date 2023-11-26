using BookStore.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BookStore.Customers
{
    public class VIPCustomer : Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public override List<IBook> BorrowedBooks { get; set; }
        public CustomerType CustomerType { get; set; }

        public VIPCustomer(string firstName, string lastName, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            BorrowedBooks = new List<IBook>();
            CustomerType = CustomerType.VIP;
        }

        public override void ShowBorrowedBooks()
        {
            Console.WriteLine("VIP:");
            foreach (var book in BorrowedBooks)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
