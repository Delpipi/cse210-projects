public class ManagerGoal
{
    private List<Goal> _goals;
    private int _score;

    public ManagerGoal()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void start()
    {
        int menu = 0;
        do
        {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from menu: ");
            string answer = Console.ReadLine();
            menu = int.Parse(answer);

            if (menu != 6)
            {
                if (menu == 1)
                {
                    Console.WriteLine("The types of Goals are: ");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goals");
                    Console.Write("Which type of goal would you like to create? ");
                    string strType = Console.ReadLine();
                    int type = int.Parse(strType);

                    Console.Write("what is the name of your goal? ");
                    string shortName = Console.ReadLine();
                    Console.Write("what is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("what is the amount of points associated with this goal? ");
                    string points = Console.ReadLine();

                    if (type == 1)
                    {
                        Goal goal = new SimpleGoal(shortName, description, int.Parse(points));
                        CreateGoal(goal);

                    }
                    else if (type == 2)
                    {
                        Goal goal = new EternalGoal(shortName, description, int.Parse(points));
                        CreateGoal(goal);
                    }
                    else if (type == 3)
                    {
                        Console.Write("How many times this goal need to be accomplished for a bonus? ");
                        string target = Console.ReadLine();
                        Console.Write("What is the bonus for accomplishing it that many time? ");
                        string bonus = Console.ReadLine();
                        Goal goal = new ChecklistGoal(shortName, description, int.Parse(points), int.Parse(bonus), int.Parse(target));
                        CreateGoal(goal);
                    }
                    else
                    {
                        Console.WriteLine("Unknow data");
                    }
                }
                else if (menu == 2)
                {
                    Console.WriteLine("The goals are:");
                    ListGoalDetails();
                }
                else if (menu == 3)
                {
                    Console.Write("What is the filename for the goal file? ");
                    string filename = Console.ReadLine();
                    SaveGoals(filename);
                }
                else if (menu == 4)
                {
                    Console.Write("What is the filename for the goal file? ");
                    string filename = Console.ReadLine();
                    LoadGoals(filename);
                }
                else if (menu == 5)
                {
                    Console.WriteLine("The goals are:");
                    ListGoalNames();

                    Console.Write("Which goal did you accomplish? ");
                    string goal = Console.ReadLine();
                    int goalLocation = int.Parse(goal);
                    RecordEvent(goalLocation);
                }
                else
                {
                    Console.WriteLine("Unknow data");
                }
            }
            else
            {
                Console.WriteLine("Bye, see you soon");
            }
        } while (menu != 6);

    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }

    private void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            int goalLocation = i + 1;
            Goal goal = _goals[i];

            Console.WriteLine($"{goalLocation}. {goal.GetShortName()}");
        }
    }

    private void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalLocation)
    {
        int index = goalLocation - 1;
        if (goalLocation <= _goals.Count)
        {
            Goal goal = _goals[index];
            goal.RecordEvent();
            _score += goal.GetPoints();
        }
        else
        {
            Console.WriteLine("Goal not exists");
        }
    }

    private void SaveGoals(string filename)
    {
        if (filename.Trim() != "" && filename != null)
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
        }
    }

    public void LoadGoals(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        //Retrieve user score
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");

            //Get The Object part
            string typeOfGoal = parts[0];
            string goalDetails = parts[1];

            //Get the Goal details parts
            string[] details = goalDetails.Split(",");
            string shortName = details[0];
            string description = details[1];
            int points = int.Parse(details[2]);

            if (typeOfGoal == "SimpleGoal")
            {
                bool isComplete = bool.Parse(details[3]);
                SimpleGoal simpleGoal = new SimpleGoal(shortName, description, points, isComplete);

                _goals.Add(simpleGoal);
            }
            else if (typeOfGoal == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(shortName, description, points);

                _goals.Add(eternalGoal);
            }
            else if (typeOfGoal == "ChecklistGoal")
            {
                int bonus = int.Parse(details[3]);
                int target = int.Parse(details[4]);
                int amountCompleted = int.Parse(details[5]);
                ChecklistGoal checklistGoal = new ChecklistGoal(shortName, description, points, bonus, target, amountCompleted);

                _goals.Add(checklistGoal);
            }
            else
            {
                Console.WriteLine("Unknow data");
            }
        }
    }
}