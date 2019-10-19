namespace OOP.Generic
{
    class GoalKeeper : FootballPlayer<GoalKeeper>, IGoalKeeper
        {
            public FootballPlayerPositionAsEnum Position => FootballPlayerPositionAsEnum.GoalKeeper;

            public string SaveTheBall()
            {
                return "Catcehd the ball";
            }

            public string CatchTheOppenent(IForward player)
            {
                return "Oppenent catched";
            }

            public string GoalKick(double speed)
            {
                return "Goal kick";
            }
        }
    }