using BookStore.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class BookStockLogger : LoggerDecorator
    {
        public BookStockLogger(ILogger logger) : base(logger)
        {
        }

        public override void Log(string message)
        {
            base.Log(message + ": " + "Book stock updated!");
        }
    }
}
