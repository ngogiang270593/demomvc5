namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductAdjust")]
    public partial class ProductAdjust
    {
        public int Id { get; set; }

        public long? ProductId { get; set; }

        public int? Number { get; set; }

        [StringLength(1000)]
        public string Notes { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string Creator { get; set; }

        public virtual Product Product { get; set; }
    }
}
