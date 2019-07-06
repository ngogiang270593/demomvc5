namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OtherListTable")]
    public partial class OtherListTable
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string OLCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string OtherListName { get; set; }

        public bool? SysList { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ValueType { get; set; }
    }
}
