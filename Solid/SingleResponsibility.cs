using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Solid {

    class SingleResponsibility {
    }

    interface IUser {

        void Register(UserRegisterModel model);

        void Login(UserLoginModel model);

        //Problem
        void Log(string message);

        void GetUserOrders();

    }

    public class UserLoginModel {
    }

    public class UserRegisterModel {
    }

    class Logger : ILogger {
        public void Log(string message) {
            Console.WriteLine("Logged");
        }
    }

    interface ILogger {
        void Log(string message);
    }

    public class OrderRepository {

        public List<Order> GetAll() {
            return default;//All Orders
        }

        public List<Order> GetOrdersByEmployee(Expression<Func<Employee, bool>> filter = null) {
            return default;//Some Orders
        }
    }

    public class Order {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        // Other properties
    }

    public class Employee {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    public class ProductManager {
        DbContext context = new DbContext();

        public void TransactionalOperator() {
            context.Update();
            context.Insert();
        }

        public void Insert() => context.Insert();

        public void Update() => context.Update();
    }

    public class Manager {

        ProductManager productManager = new ProductManager();

        public void Add() {
            productManager.TransactionalOperator();//Wrong code because this method calling a lot of operation
        }

        public void Insert() => productManager.Insert();//Correct code

        public void Update() => productManager.Update();//Correct code
    }

    class DbContext {
        public DbContext() {
        }

        internal void Insert() {
            Console.WriteLine("Inserted");
        }

        internal void Update() {
            Console.WriteLine("Updated");
        }
    }
}
