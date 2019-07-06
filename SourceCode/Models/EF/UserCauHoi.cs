namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserCauHoi")]
    public partial class UserCauHoi
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        [StringLength(500)]
        public string HoTen { get; set; }

        [StringLength(500)]
        public string Email { get; set; }

        [StringLength(500)]
        public string TieuDe { get; set; }

        public string NoiDung { get; set; }

        public int? IsTraLoi { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(500)]
        public string Creator { get; set; }

        public DateTime? NgayTraLoi { get; set; }

        [StringLength(500)]
        public string NguoiTraLoi { get; set; }
    }
}
