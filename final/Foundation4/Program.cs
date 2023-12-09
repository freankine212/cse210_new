using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exerciseList = new List<Exercise>();
        
        Running running = new Running("December 10, 2023", 60, 5);
        exerciseList.Add(running);

        StationaryBicycle stationaryBicycle = new StationaryBicycle("November 12, 2023", 60, 10);
        exerciseList.Add(stationaryBicycle);

        Swimming swimming = new Swimming("August 15, 2023", 30, 15);
        exerciseList.Add(swimming);

        Console.WriteLine("Exercises:");
        Console.WriteLine();

        foreach (Exercise exercise in exerciseList) 
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}