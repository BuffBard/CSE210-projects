

class Program
{
    static void Main(string[] args)
    {
        ActivityList activities=new();
        foreach(Activity activity in activities.GetActivities())
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}