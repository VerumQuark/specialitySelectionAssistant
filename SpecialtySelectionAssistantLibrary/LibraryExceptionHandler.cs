using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SpecialtySelectionAssistantLibrary
{
    class LibraryExceptionHandler
    {
        static public void HandleException(Exception ex)
        {
            File.AppendAllText("LibraryExceptionLog.txt", ex.ToString());
        }

        static public void HandleException(Exception ex, string message)
        {
            File.AppendAllText("LibraryExceptionLog.txt", message);
            File.AppendAllText("LibraryExceptionLog.txt", ex.ToString());
        }
    }
}
}
