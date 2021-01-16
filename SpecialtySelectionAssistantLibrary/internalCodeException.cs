using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialtySelectionAssistantLibrary
{
    class InternalCodeException : Exception
    {
        public InternalCodeException()
        {
        }
        public InternalCodeException(string message)
        : base(message)
        {
        }

        public InternalCodeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
