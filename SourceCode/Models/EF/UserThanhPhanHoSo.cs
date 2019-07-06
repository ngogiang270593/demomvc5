namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserThanhPhanHoSo")]
    public partial class UserThanhPhanHoSo
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        public int? ThanhPhanHoSoId { get; set; }

        [StringLength(50)]
        public string MaHoSo { get; set; }

        [StringLength(500)]
        public string TenHoSo { get; set; }

        public bool? IsDefault { get; set; }

        [StringLength(500)]
        public string ImagesUrl { get; set; }

        public bool? IsCheck { get; set; }

        [StringLength(200)]
        public string fpath { get; set; }

        [StringLength(200)]
        public string contentType { get; set; }
    }
}
