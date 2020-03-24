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

                double decimalNumberOfSick = Math.Truncate(numberOfSick);
                double decimalNumberKilledPeople = Math.Truncate(numberOfKilledPeople);

                return ($"There are {decimalNumberOfSick} people sick with {task.Virus.Name} in the city of {task.City.Name}, {decimalNumberKilledPeople} of which died"); ;
            };
            Task1.CheckSolver(TaskSolver);
        }
    }
}
