namespace OOP.Generic
{
    class ForwardFootballPlayer : FootballPlayer<ForwardFootballPlayer>, IForward
        {
            public FootballPlayerPositionAsEnum Position { get => FootballPlayerPositionAsEnum.Forward; }

            public string CatchTheOppenent(IForward player)
            {
                return "Oppenent catched";
            }

            public string CrossTheBall(double speed, double angle)
            {
                return "Cross the ball";
            }

            public string Shoot(double speed, double angle)
            {
                return "Shoot";
            }
        }
    }