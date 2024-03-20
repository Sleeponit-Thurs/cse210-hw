class EternalGoal : Goal
{
    private int _pointValue;
    private string _goalName;
    private int _checksRemaining;
    private int _bonusPoints;
    public EternalGoal(string nameforpremade)
    {
        _goalName = nameforpremade;
        _pointValue = 25;
        _checksRemaining = 1;
        _bonusPoints = 0;


    }
    public EternalGoal(string name, int points)
    {
        _goalName = name;
        _pointValue = points;
        _checksRemaining = 1;
        _bonusPoints = 0;

    }
    public EternalGoal(string name, int points, int checks, int bonus)
    {
        _goalName = name;
        _pointValue = points;
        _checksRemaining = checks;
        _bonusPoints = bonus;

    }
    public override string ToString()
    {
        return $"{_goalName},{_pointValue},{_checksRemaining},{_bonusPoints}";
    }
}