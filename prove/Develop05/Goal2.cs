public class Goal2 : AllGoals
{
    private string _goalAnswer2;
    private string _goalAnswer3;

    public Goal2(string goalAnswer2, string goalAnswer3, string goalAnswer1) : base(goalAnswer1)
    {
        _goalAnswer2 = goalAnswer2;
        _goalAnswer3 = goalAnswer3;
    }


    public override string GetGoal()
    {
        // return _goalAnswer2;
        return "[] " + _goalAnswer2 + " (" + _goalAnswer3 + ")";
    }
}