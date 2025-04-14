using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        //Create  Activities on "03 Nov 2022"
        RunningActivity runningActivity1 = new RunningActivity("03 Nov 2022", 30, 4.8);
        CyclingActivity cyclingActivity1 = new CyclingActivity("03 Nov 2022", 30, 9.7);
        SwimmingActivity swimmingActivity1 = new SwimmingActivity("03 Nov 2022", 30, 20);

        activities.Add(runningActivity1);
        activities.Add(cyclingActivity1);
        activities.Add(swimmingActivity1);

        //Create  Activities on "05 Dec 2023"
        RunningActivity runningActivity2 = new RunningActivity("05 Dec 2023", 40, 9.4);
        CyclingActivity cyclingActivity2 = new CyclingActivity("05 Dec 2023", 40, 10.2);
        SwimmingActivity swimmingActivity2 = new SwimmingActivity("05 Dec 2023", 40, 30);

        activities.Add(runningActivity2);
        activities.Add(cyclingActivity2);
        activities.Add(swimmingActivity2);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}