
class ActivityList
{
    List<Activity> activities = [
            new Running("03 Nov 2022",30,3.0),
            new Swimming("11 Dec 1998",120,6),
            new Cycling("29 Feb 2004",22,18.4)
        ];
    public List<Activity> GetActivities()
    {
        return activities;
    }
}