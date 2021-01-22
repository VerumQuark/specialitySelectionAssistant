using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialitySelectionAssistant.Tests
{
    public abstract class TwoIndexTest<T> : Test<T>
    {
        public abstract int currentSpecialityIndex { get; set; }
        public abstract int currentListQuestionIndex { get; set; }

        public abstract void CreateTest(Faculty facultyValue);
    }
}
