using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialitySelectionAssistant.Tests
{
    public abstract class OneIndexTest<T> : Test<T>
    {
       public abstract int _currentComparisonQuestionIndex { get; set; }
       public abstract void CreateTest();
    }
}
