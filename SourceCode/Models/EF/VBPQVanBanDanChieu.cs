namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VBPQVanBanDanChieu")]
    public partial class VBPQVanBanDanChieu
    {
        public int ID { get; set; }

        public int? VanBanDanChieuId { get; set; }

        public int? DocumentId { get; set; }
    }
}
