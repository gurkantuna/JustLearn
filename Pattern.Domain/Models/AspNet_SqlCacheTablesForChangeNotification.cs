namespace Pattern.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AspNet_SqlCacheTablesForChangeNotification
    {
        [Key]
        [StringLength(450)]
        public string tableName { get; set; }

        public DateTime notificationCreated { get; set; }

        public int changeId { get; set; }
    }
}
