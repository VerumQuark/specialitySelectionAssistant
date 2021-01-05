using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace SpecialtySelectionAssistantLibrary
{
    static public class FacultiesMinDeviation
    {
        static string jsonString = Encoding.UTF8.GetString(Properties.Resources.faculties);

        static public Faculty getFaculty(HollandResult hollandResult)
        {
            List<Faculty> alterFacultiesStorage;
            alterFacultiesStorage = JsonSerializer.Deserialize<List<Faculty>>(jsonString);

            Faculty minAbsDeviationFaculty = new Faculty();
            int minAbsDeviation = int.MaxValue;

            foreach (Faculty faculty in alterFacultiesStorage)
            {
                int absDeviation = 0;

                absDeviation += Math.Abs(hollandResult.realistic     - faculty.hollandCharacteristics.realistic);
                absDeviation += Math.Abs(hollandResult.intelligent   - faculty.hollandCharacteristics.intelligent);
                absDeviation += Math.Abs(hollandResult.social        - faculty.hollandCharacteristics.social);
                absDeviation += Math.Abs(hollandResult.conventional  - faculty.hollandCharacteristics.conventional);
                absDeviation += Math.Abs(hollandResult.enterprising  - faculty.hollandCharacteristics.enterprising);
                absDeviation += Math.Abs(hollandResult.artistic      - faculty.hollandCharacteristics.artistic);

                if (absDeviation < minAbsDeviation)
                {
                    minAbsDeviation = absDeviation;
                    minAbsDeviationFaculty = faculty;
                }

            }

            return minAbsDeviationFaculty;
        }
    }
}
