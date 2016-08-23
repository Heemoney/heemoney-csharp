using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heemoney
{
    public class HeemoneyException : ApplicationException
    {
        public HeemoneyException() { }

        public HeemoneyException(string message)
            : base(message) { }
    }
}
