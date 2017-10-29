namespace mvc1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public Guid ProductID { get; set; }

        public Guid? CategoryID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        public virtual Category Category { get; set; }
    }
}
