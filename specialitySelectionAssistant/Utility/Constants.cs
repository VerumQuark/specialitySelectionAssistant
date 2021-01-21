using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialitySelectionAssistant
{
    static public class Constants
    {
        static public readonly int COMPARATION_QUESTION_COUNT = 30;



        static public readonly string[] FIRST_ZNO_SUBJECTS = new string[] {
            "Українська мова і література",
            ""
        };
        static public readonly string[] SECOND_ZNO_SUBJECTS = new string[] {
            "Математика",
            "Біологія",
            "Історія України",
            ""
        };
        static public readonly string[] THIRD_ZNO_SUBJECTS = new string[] {
            "Історія України",
            "Англійська мова",
            "Німецька мова",
            "Французька мова",
            "Іспанська мова",
            ""
        };
        static public readonly string[] OTHER_ZNO_SUBJECTS = new string[] {
            "Історія України",
            "Географія",
            "Біологія",
            "Фізика",
            "Хімія",
            "Англійська мова",
            "Німецька мова",
            "Французька мова",
            "Іспанська мова",
            "Математика",
            ""
        };
        static public readonly int MAX_ZNO_POINTS = 200;
        static public readonly int MIN_ZNO_POINTS = 100;
        static public readonly int MAX_ZNO_POINTS_DIGIT_COUNT = MAX_ZNO_POINTS.ToString().Length;
        static public readonly int SUBJECT_COUNT = 5;
        static public readonly int MANDATORY_SUBJECTS_COUNT = 3;
    }
}
