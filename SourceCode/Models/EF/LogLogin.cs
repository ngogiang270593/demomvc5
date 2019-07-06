namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogLogin")]
    public partial class LogLogin
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        public int? UserRole { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateLogin { get; set; }

        public string Description { get; set; }
    }
}
