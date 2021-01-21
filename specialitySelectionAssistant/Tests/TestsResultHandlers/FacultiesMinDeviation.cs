using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using specialitySelectionAssistant.Exceptions;

namespace specialitySelectionAssistant.Tests
{
    static public class FacultiesMinDeviation
    {
        static readonly string jsonString;

        static FacultiesMinDeviation()
        {
            try
            {
                jsonString = Encoding.UTF8.GetString(Properties.Resources.faculties);
            }
            catch (Exception ex)
            {
                string message = "FacultiesMinDeviation. Get Json string error";
                ExceptionHandler.CriticalException(ex, message);
            }
        }

        static public Faculty GetFaculty(HollandResult hollandResult)
        {
            Faculty minAbsDeviationFaculty = new Faculty();

            try
            {
                List<Faculty> alterFacultiesStorage;
                alterFacultiesStorage = JsonSerializer.Deserialize<List<Faculty>>(jsonString);

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
            }
            catch (Exception ex)
            {
                string message = "Pair generator. Json deserialization error";
                ExceptionHandler.CriticalException(ex, message);
            }

            return minAbsDeviationFaculty;
        }
    }
}
