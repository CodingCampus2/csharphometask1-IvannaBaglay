using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task1, string> TaskSolver = task =>
            {
                if (float.TryParse(task.City.SickPercentage, out float sickPercentage)
                    && float.TryParse(task.Virus.KillProbability, out float  killProbability)
                    && int.TryParse(task.City.Population, out int population))
                {
                    float numberOfSick = population * sickPercentage;
                    float numberOfKilledPeople = numberOfSick * killProbability;

                    double roundedNumberOfSick = MathF.Truncate(numberOfSick);
                    double roundedNumberKilledPeople = MathF.Truncate(numberOfKilledPeople);

                    return $"There are {roundedNumberOfSick} people sick with {task.Virus.Name} in the city of {task.City.Name}, {roundedNumberKilledPeople} of which died";
                }
                return "Error: Wrong data";
            };
            Task1.CheckSolver(TaskSolver);
        }
    }
}
