public class Goal3 : AllGoals
{
    private string _goalAnswer2;
    private string _goalAnswer3;
    private string _goalAnswer4;
    private string _attempt;

    public Goal3(string goalAnswer2, string goalAnswer3, string goalAnswer4, string attempt, string goalAnswer1) : base(goalAnswer1)
    {
        _goalAnswer2 = goalAnswer2;
        _goalAnswer3 = goalAnswer3;
        _goalAnswer4 = goalAnswer4;
        _attempt = attempt;
    }


    public override string GetGoal()
    {

        return "[]" + _goalAnswer2 + " (" + _goalAnswer3 + ") --- Currently completed: " + _attempt + '/' + _goalAnswer4;
    }
}