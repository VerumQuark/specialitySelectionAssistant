using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialitySelectionAssistant
{
    public class UnexpectedHollandTypeException : Exception
    {
        public UnexpectedHollandTypeException()
        {
        }

        public UnexpectedHollandTypeException(string message)
        : base(message)
        {
        }

        public UnexpectedHollandTypeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
