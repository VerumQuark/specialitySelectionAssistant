using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialitySelectionAssistant
{
    public class ZnoEmptyException : Exception
    {
        public ZnoEmptyException()
        {
        }

        public ZnoEmptyException(string message)
        : base(message)
        {
        }

        public ZnoEmptyException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
