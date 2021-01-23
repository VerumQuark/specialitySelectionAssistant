using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace specialitySelectionAssistant.Exceptions
{
    class ExceptionHandler
    {
        static public void HandleException(Exception ex)
        {
            MessageBox.Show(ex.Message);
            File.AppendAllText("ExceptionLog.txt", ex.ToString());
        }

        static public void HandleException(Exception ex, string message)
        {
            MessageBox.Show(message);
            File.AppendAllText("ExceptionLog.txt", ex.ToString());
        }

        static public void CriticalException(Exception ex)
        {
            MessageBox.Show("Критична внутрішня помилка. Перевірте цілісність файлів.");
            File.AppendAllText("ExceptionLog.txt", ex.ToString());
            Application.Exit();
        }

        static public void CriticalException(Exception ex, string message)
        {
            MessageBox.Show("Критична внутрішня помилка. Перевірте цілісність файлів.");
            MessageBox.Show(message);
            File.AppendAllText("ExceptionLog.txt", ex.ToString());
            Application.Exit();
        }
    }
}