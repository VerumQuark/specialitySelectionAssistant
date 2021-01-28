using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialitySelectionAssistant.Exceptions
{
    public class FormMismatchException : Exception
    {
        public FormMismatchException()
        {
        }

        public FormMismatchException(string message)
        : base(message)
        {
        }

        public FormMismatchException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
