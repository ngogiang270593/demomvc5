namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HitCounter")]
    public partial class HitCounter
    {
        [Key]
        [Column(TypeName = "smalldatetime")]
        public DateTime Date { get; set; }

        public long? Counter { get; set; }
    }
}
