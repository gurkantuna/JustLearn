using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid {
    class LiskovsSubstition {
    }

    #region Wrong Code
    /*
    public abstract class VehicleBase {

        public double CurrentSpeed { get; set; }

        public void SpeedUp(double level) {
            CurrentSpeed += level;
            Console.WriteLine($"Vehicle accelarting {level} km");
        }

        public void Brake(double level) {
            CurrentSpeed -= level;
            Console.WriteLine($"Vehicle breaking {level} km");
        }

        public abstract void Fly();

        public abstract void Swim();
    }

    public class Airplane : VehicleBase {
        public override void Fly() {
            Console.WriteLine("Airplane is flying");
        }

        public override void Swim() {
            throw new NotImplementedException();//!!!!!!!!
        }
    }

    public class Boat : VehicleBase {
        public override void Fly() {
            throw new NotImplementedException();//!!!!!!!!
        }

        public override void Swim() {
            Console.WriteLine("Boat is swimming");
        }
    }

    public class Car : VehicleBase {
        public override void Fly() {
            throw new NotImplementedException();//!!!!!!!
        }

        public override void Swim() {
            throw new NotImplementedException();//!!!!!!!
        }
    }
    */
    #endregion

    interface IVehicle {
        double CurrentSpeed { get; set; }

        void SpeedUp(double level);
        void Brake(double level);
    }

    interface IFlyable {
        void Fly();
    }

    interface ISwimmable {
        void Swim();
    }

    public class Car : IVehicle {
        public double CurrentSpeed { get; set; }

        public void Brake(double level) {
            CurrentSpeed -= level;
            Console.WriteLine($"Car is braking {level} km ");
        }

        public void SpeedUp(double level) {
            CurrentSpeed += level;
            Console.WriteLine($"Car is accelerating {level} km ");
        }
    }

    public class Airplane : IVehicle, IFlyable {
        public double CurrentSpeed { get; set; }

        public void Brake(double level) {
            CurrentSpeed -= level;
            Console.WriteLine($"Airplane is braking {level} km ");
        }

        public void Fly() {
            Console.WriteLine("Airplane is flying");
        }

        public void SpeedUp(double level) {
            CurrentSpeed += level;
            Console.WriteLine($"Airplane is accelerating {level} km ");
        }
    }
    public class Boat : IVehicle, ISwimmable {
        public double CurrentSpeed { get; set; }

        public void Brake(double level) {
            CurrentSpeed -= level;
            Console.WriteLine($"Boat is braking {level} km ");
        }

        public void SpeedUp(double level) {
            CurrentSpeed += level;
            Console.WriteLine($"Boat is accelerating {level} km ");
        }

        public void Swim() {
            Console.WriteLine("Boat is swimming");
        }
    }


}
