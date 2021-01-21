using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialitySelectionAssistant
{
    class JsonSerializationException : Exception
    {
        public JsonSerializationException()
        {
        }

        public JsonSerializationException(string message)
        : base(message)
        {
        }

        public JsonSerializationException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
