namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreImage")]
    public partial class StoreImage
    {
        public long Id { get; set; }

        [StringLength(500)]
        public string ImageURL { get; set; }

        public int? StoreId { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        [StringLength(500)]
        public string Domain { get; set; }

        public virtual Store Store { get; set; }
    }
}
