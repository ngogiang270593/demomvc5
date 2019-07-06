namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserTraLoiCauHoi")]
    public partial class UserTraLoiCauHoi
    {
        public int Id { get; set; }

        public int? UserCauHoiId { get; set; }

        public string NoiDung { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(100)]
        public string Creator { get; set; }

        [StringLength(500)]
        public string TieuDe { get; set; }

        [StringLength(500)]
        public string Email { get; set; }

        [StringLength(500)]
        public string HoTen { get; set; }
    }
}
