namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserCauHoiFileDinhKem")]
    public partial class UserCauHoiFileDinhKem
    {
        public int Id { get; set; }

        public int? UserCauHoiId { get; set; }

        [StringLength(500)]
        public string Fname { get; set; }

        [StringLength(200)]
        public string Fpath { get; set; }

        [StringLength(200)]
        public string ContentType { get; set; }
    }
}
