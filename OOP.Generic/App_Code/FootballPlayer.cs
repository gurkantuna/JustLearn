namespace OOP.Generic
{
    internal abstract class FootballPlayer<TPosition> : PlayerBase where TPosition : IFootbalPlayerPosition
    {
        public virtual string TakePass(double angle, FootDirection foot, FootballPlayer<TPosition> player)
        {
            return "Take Pass";
        }

        public virtual string Pass(double angle, FootDirection foot, FootballPlayer<TPosition> player)
        {
            return "Pass";
        }
    }
}