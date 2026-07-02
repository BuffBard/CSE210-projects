using System;

class Program
{
    static void Main(string[] args)
    {
        
        GoalList goals = new GoalList();
        int userInput=0;
        List<string> _menu=new(){"Create New Goal", "List Goals","Save Goals","Load Goals","Record Event","Quit"};
        
        while(userInput != 6){
            Spinner(2);
            Console.WriteLine($"You have: {goals.GetPointTotal()}");
            Console.WriteLine("Menu Options:");
            for(int i=0;i<_menu.Count();i++){
                Console.WriteLine($"    {i+1}. {_menu[i]}");
                }
                Spinner(1);
            Console.Write("Choice: ");
            userInput = int.Parse(Console.ReadLine());

            switch(userInput){
                case 1:
                    Console.WriteLine("Goal Type:");
                    Console.WriteLine("1. Simple");
                    Console.WriteLine("2. Eternal");
                    Console.WriteLine("3. Checklist");
                    Spinner(1);
                    Console.Write("Choice: ");
                    int type = int.Parse(Console.ReadLine());
                    Console.Write("Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Description: ");
                    string desc = Console.ReadLine();
                    Console.Write("Points: ");
                    int points = int.Parse(Console.ReadLine());
                    if (type == 1){
                        goals.AddGoal(new SimpleGoal(title, desc, points));
                    }
                    else if (type == 2){
                        goals.AddGoal(new EternalGoal(title, desc, points));
                    }
                    else{
                        Console.Write("Target count: ");
                        int threshold = int.Parse(Console.ReadLine());

                        Console.Write("Bonus: ");
                        int bonus = int.Parse(Console.ReadLine());

                        goals.AddGoal(new ChecklistGoal(title,desc,points,bonus,threshold));
                    }
                    break;

                case 2:
                    goals.DisplayGoals();
                    break;

                case 3:
                    Console.Write("Filename: ");
                    goals.Save(Console.ReadLine());
                    break;

                case 4:
                    Console.Write("Filename: ");
                    goals.Load(Console.ReadLine());
                    break;

                case 5:
                    goals.DisplayGoals();
                    Console.Write("Goal Number: ");
                    int index = int.Parse(Console.ReadLine());
                    goals.RecordEvent(index - 1);
                    break;
            }
        }
    }
    public static void Spinner(int seconds){
            char[] spinner = ['|', '/', '-', '\\'];
            DateTime endTime = DateTime.Now.AddSeconds(seconds);
            int i = 0;
            while (DateTime.Now < endTime){
                Console.Write(spinner[i % spinner.Length]);
                Thread.Sleep(100);
                Console.Write("\b");
                i++;
            }
            Console.Write(" \b");
        }
        
}