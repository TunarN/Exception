using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer.Models
{
    class NotAvailableException:Exception
    {
        public NotAvailableException(string message):base(message)
        {
           
        }
    }
}
