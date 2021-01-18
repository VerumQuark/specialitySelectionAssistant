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
        static readonly string jsonString = Encoding.UTF8.GetString(Properties.Resources.faculties);

        static public Faculty GetFaculty(HollandResult hollandResult)
        {
            List<Faculty> alterFacultiesStorage;
            alterFacultiesStorage = JsonSerializer.Deserialize<List<Faculty>>(jsonString);

            Faculty minAbsDeviationFaculty = new Faculty();
            int minAbsDeviation = int.MaxValue;

            foreach (Faculty faculty in alterFacultiesStorage)
            {
                int absDeviation = 0;

                absDeviation += Math.Abs(hollandResult.Realistic     - faculty.hollandCharacteristics.Realistic);
                absDeviation += Math.Abs(hollandResult.Intelligent   - faculty.hollandCharacteristics.Intelligent);
                absDeviation += Math.Abs(hollandResult.Social        - faculty.hollandCharacteristics.Social);
                absDeviation += Math.Abs(hollandResult.Conventional  - faculty.hollandCharacteristics.Conventional);
                absDeviation += Math.Abs(hollandResult.Enterprising  - faculty.hollandCharacteristics.Enterprising);
                absDeviation += Math.Abs(hollandResult.Artistic      - faculty.hollandCharacteristics.Artistic);

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
