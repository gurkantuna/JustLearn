
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generic
{
    class Program
    {
        static void Main(string[] args)
        {

            ForwardFootballPlayer forward = new ForwardFootballPlayer
            {
                Id = 1,
                Name = "Lionel Messi",
                UniformNumber = 10
            };

            ForwardFootballPlayer forward2 = new ForwardFootballPlayer
            {
                Id = 2,
                Name = "Cenk Tosun",
                UniformNumber = 10
            };

            forward.TakePass(45, FootDirection.Right, forward2);
            forward.Pass(45, FootDirection.Right, forward);
            forward.TakePass(60, FootDirection.Left, forward2);
            forward.Shoot(120, 25);
            //forward.SaveTheBall();//Can't compile!

            GoalKeeper keeper = new GoalKeeper
            {
                Id = 3,
                Name = "Manuel Neuer",
                UniformNumber = 1
            };
            keeper.SaveTheBall();
            keeper.GoalKick(100);
            //keeper.CrossTheBall();//Can't compile!
            //keeper.Shoot();//Can't compile!

            //FootballPlayer<ForwardFootballPlayer> player = new FootballPlayer<ForwardFootballPlayer>();//Can't compile! You can create an instance from only inherited by FootballPlayer class
        }
    }
}
