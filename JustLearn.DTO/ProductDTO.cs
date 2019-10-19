using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JustLearn.DTO {
    [DataContract]
    public class ProductDTO  {

        [DataMember]
        public int ProductID { get; set; }

        [DataMember]
        public string ProductName { get; set; }

        public int? SupplierID { get; set; }

        [DataMember]
        public int? CategoryID { get; set; }

        [DataMember]
        public string CategoryName { get; set; }

        public string QuantityPerUnit { get; set; }

        [DataMember]
        public decimal? UnitPrice { get; set; }

        [DataMember]
        public short? UnitsInStock { get; set; }

        [DataMember]
        public short? UnitsOnOrder { get; set; }

        public short? ReorderLevel { get; set; }

        public bool Discontinued { get; set; }       
    }
}
