using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.UI {
    class Program {
        static void Main(string[] args) {
            //You should use IOC container below new instances

            //Single Responsibility Principle
            ProductManager productManager = new ProductManager();
            productManager.Insert();//we can using separately insert and update
            productManager.Update();

            OrderRepository rep = new OrderRepository();
            rep.GetAll();
            rep.GetOrdersByEmployee(e => e.FirstName == "John");

            //Open-Closed Principle
            CustomerManager customerManager = new CustomerManager(new MsSqlCustomerDAL());
            CustomerManager customerManager2 = new CustomerManager(new OracleCustomerDAL());
            customerManager.Add();
            customerManager2.Add();

            //Liskov' Substition Principle
            Car car = new Car();
            car.SpeedUp(20);
            car.Brake(10);
            //car.Fly();//Absurd
            Airplane airplane = new Airplane();
            airplane.SpeedUp(100);
            airplane.Fly();
            //airplane.Swim();//Absurd
            Boat boat = new Boat();
            boat.SpeedUp(50);
            //boat.Fly();//Absurd

            //Dependency Inversion

            Console.Read();
        }
    }
}
