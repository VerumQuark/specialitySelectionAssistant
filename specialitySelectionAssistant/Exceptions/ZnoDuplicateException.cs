using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialitySelectionAssistant
{
    public class ZnoDuplicateException : Exception
    {
        public ZnoDuplicateException()
        {
        }

        public ZnoDuplicateException(string message)
        : base(message)
        {
        }

        public ZnoDuplicateException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
