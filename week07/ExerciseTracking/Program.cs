using System;

class Program
{
    static void Main(string[] args)
    {
        // create activities and put them in a list
        RunningActivity running1 = new RunningActivity("24 Jun 2023", 90, 17.7);
        CyclingActivity cycling1 = new CyclingActivity("07 Sep 2024", 45, 95.5);
        SwimmingActivity swimming1 = new SwimmingActivity("17 Dec 2023", 60, 40);
        List<Activity> activitiesList = [running1, cycling1, swimming1];

        // clear console and display summary for each item in list
        Console.Clear();
        foreach (Activity activity in activitiesList)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine(); // blank line at end
    }
}