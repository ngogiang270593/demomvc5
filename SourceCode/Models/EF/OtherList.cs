namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OtherList")]
    public partial class OtherList
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string Type { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public bool? Status { get; set; }
    }
}
