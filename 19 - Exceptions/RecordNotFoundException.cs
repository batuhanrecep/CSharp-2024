using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _19___Exceptions
{
    public class RecordNotFoundException:Exception
    {
        public RecordNotFoundException(string message):base(message)
        {
            
        }
    }
}
