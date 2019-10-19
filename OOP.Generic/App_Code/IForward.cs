namespace OOP.Generic
{
    interface IForward : IMidField, IFootbalPlayerPosition
        {
            string Shoot(double speed, double angle);
        }
    }