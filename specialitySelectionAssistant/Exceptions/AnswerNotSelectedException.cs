using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialitySelectionAssistant.Exceptions
{
    public class AnswerNotSelectedException : Exception
    {
        public AnswerNotSelectedException()
        {
        }

        public AnswerNotSelectedException(string message)
        : base(message)
        {
        }

        public AnswerNotSelectedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
