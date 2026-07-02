class GoalList
{
    protected int _pointTotal=0;
    protected List<Goal>_goals=new();

    public int GetPointTotal()
    {
        return _pointTotal;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void Save(string filename){
        using (StreamWriter outputFile = new StreamWriter(filename)){
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
        }
    }
    public void Load(string filename)
    {
        _goals.Clear();
        _pointTotal = int.Parse(File.ReadLines(filename).First());
        foreach (string line in File.ReadLines(filename).Skip(1))
        {
            string[] parts = line.Split(':');
            string type = parts[0];
            string[] data = parts[1].Split(',');

            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(
                        data[0],
                        data[1],
                        int.Parse(data[2]),
                        bool.Parse(data[3])));
                    break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(
                        data[0],
                        data[1],
                        int.Parse(data[2])));
                    break;

                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(
                        data[0],
                        data[1],
                        int.Parse(data[2]),
                        bool.Parse(data[3]),
                        int.Parse(data[4]),
                        int.Parse(data[5]),
                        int.Parse(data[6])));
                    break;
            }
        }
    }
    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].Display();
        }
    }
    public void RecordEvent(int index)
    {
        if (index < 0 || index >= _goals.Count)
            return;

        int earned = _goals[index].Complete();
        _pointTotal += earned;

        Console.WriteLine($"You earned {earned} points!");
    }
}