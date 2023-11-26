using BookStore.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Customers
{
    public  interface ICustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public List<IBook> BorrowedBooks{ get; set; }
        public CustomerType CustomerType { get; set; }


        public void ReturnBook(IBook book);
        public void BorrowBook(IBook book);
        public void ShowBorrowedBooks();
    }
}
