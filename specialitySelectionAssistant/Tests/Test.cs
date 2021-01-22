using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialitySelectionAssistant.Tests
{
    public abstract class Test<T>
    {
        public abstract bool isLastQuestion { get; set; }
        public abstract bool isFirstQuestion { get; set; }

        public abstract Stack<T> answerStack { get; set; }

        public abstract void NextQuestion();
        public abstract void PrevQuestion();

        public abstract void SaveTestResult();
    }
}
