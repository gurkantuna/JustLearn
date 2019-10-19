namespace OOP.Generic
{
    interface IGoalKeeper : IDefence, IFootbalPlayerPosition
        {
            string SaveTheBall();
            string GoalKick(double speed);
        }
    }