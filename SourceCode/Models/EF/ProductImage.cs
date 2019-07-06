namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductImage")]
    public partial class ProductImage
    {
        public long Id { get; set; }

        [StringLength(500)]
        public string ImageURL { get; set; }

        public long? ProductId { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public virtual Product Product { get; set; }
    }
}
