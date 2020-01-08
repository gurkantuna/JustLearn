using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid {
    class OpenClosed {
    }

    #region WrongCode
    /*
    class CustomerManager {

        CustomerDAL customerDAL = new CustomerDAL();

        public void Add() {
            customerDAL.Add(DatabaseType.MSSQL);//Wrong Code
        }
    }

    enum DatabaseType {
        MSSQL,
        Oracle,
    }

    class CustomerDAL {
        internal void Add(DatabaseType type) {

            switch (type) {
                case DatabaseType.MSSQL:
                    Console.WriteLine("Added to MSSQL database");
                    break;
                case DatabaseType.Oracle:
                    Console.WriteLine("Added to Oracle database");
                    break;
                default:
                    Console.WriteLine("Added to database");
                    break;
            }
            //EF Code
        }
    }
    */
    #endregion

    //Loosely Coupled
    public class CustomerManager {

        private ICustomerDAL _customerDAL;

        public CustomerManager(ICustomerDAL customerDAL) {
            _customerDAL = customerDAL;
        }

        public void Add() {
            _customerDAL.Add();
        }
    }

    public interface ICustomerDAL {
        void Add();
    }

    public class OracleCustomerDAL : ICustomerDAL {
        public void Add() {
            Console.WriteLine("Added to Oracle");
        }
    }

    public class MsSqlCustomerDAL : ICustomerDAL {
        public void Add() {
            Console.WriteLine("Added to MSSQL");
        }
    }

    public class MySqlCustomerDAL : ICustomerDAL {
        public void Add() {
            Console.WriteLine("Added to MySQL");
        }
    }
}
