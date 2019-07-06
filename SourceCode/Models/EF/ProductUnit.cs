namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductUnit")]
    public partial class ProductUnit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductUnitID { get; set; }

        [Key]
        [StringLength(50)]
        public string ProductUnitName { get; set; }

        [StringLength(100)]
        public string Description { get; set; }
    }
}
