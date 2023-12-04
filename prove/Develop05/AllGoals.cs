
public abstract class AllGoals
{
    private string _goalAnswer1;

    public AllGoals(string goalAnswer1)
    {
        _goalAnswer1 = goalAnswer1;
    }

    public string GetgoalAnswer1()
    {
        return _goalAnswer1;
    }

    public void SetgoalAnswer1(string goalAnswer1)
    {
        _goalAnswer1 = goalAnswer1;
    }


    public abstract string GetGoal();
}