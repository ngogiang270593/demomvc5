namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhMucNganhNghe")]
    public partial class DanhMucNganhNghe
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(255)]
        public string CAP1 { get; set; }

        [StringLength(50)]
        public string CAP2 { get; set; }

        [StringLength(50)]
        public string CAP3 { get; set; }

        [StringLength(50)]
        public string CAP4 { get; set; }

        [StringLength(50)]
        public string CAP5 { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        public int? ParentId { get; set; }

        public bool? IsPhoBien { get; set; }
    }
}
