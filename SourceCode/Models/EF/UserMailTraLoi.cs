namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserMailTraLoi")]
    public partial class UserMailTraLoi
    {
        public int Id { get; set; }

        [StringLength(500)]
        public string Email { get; set; }

        [StringLength(500)]
        public string PassWord { get; set; }

        [StringLength(200)]
        public string From { get; set; }

        [StringLength(200)]
        public string Host { get; set; }

        [StringLength(200)]
        public string Port { get; set; }

        public bool? isDefault { get; set; }
    }
}
