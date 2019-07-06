namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreType")]
    public partial class StoreType
    {
        public int StoreTypeId { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public int? RootCateId { get; set; }

        public int? StoreID { get; set; }

        [Required]
        [StringLength(500)]
        public string Domain { get; set; }

        public virtual Category Category { get; set; }

        public virtual Store Store { get; set; }
    }
}
