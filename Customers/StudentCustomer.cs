using BookStore.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Customers
{
    public class StudentCustomer : Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public override List<IBook> BorrowedBooks { get; set; }
        public CustomerType CustomerType { get; set; }

        public StudentCustomer(string firstName, string lastName, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            BorrowedBooks = new List<IBook>();
            CustomerType = CustomerType.Student;
        }

        public override void ShowBorrowedBooks()
        {
            Console.WriteLine("Student:");
            foreach (var book in BorrowedBooks)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
