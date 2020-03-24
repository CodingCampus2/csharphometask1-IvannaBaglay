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
                float numberOfSick = int.Parse(task.City.Population) * float.Parse(task.City.SickPercentage);
                float numberOfKilledPeople = int.Parse(task.City.Population) * float.Parse(task.City.SickPercentage) * float.Parse(task.Virus.KillProbability);

                double roundedNumberOfSick = Math.Truncate(numberOfSick);
                double roundedNumberKilledPeople = Math.Truncate(numberOfKilledPeople);

                return ($"There are {roundedNumberOfSick} people sick with {task.Virus.Name} in the city of {task.City.Name}, {roundedNumberKilledPeople} of which died"); ;
            };
            Task1.CheckSolver(TaskSolver);
        }
    }
}
