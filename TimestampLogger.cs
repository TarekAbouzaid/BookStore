using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class TimestampLogger : LoggerDecorator
    {
        public TimestampLogger(ILogger logger) : base(logger)
        {
        }
        public override void Log(string message)
        {
            base.Log(message + ": " + DateTime.Now.ToString());
        }
    }
}
