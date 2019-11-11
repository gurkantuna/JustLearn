using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET.MVC.Models {
    public class Department {
        public Department() {
            Personels = new List<Personel>();
        }

        /// <summary>
        /// DepartmentId
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Related department name pf person
        /// </summary>
        public string Name { get; set; }

        public List<Personel> Personels { get; set; }
    }
}