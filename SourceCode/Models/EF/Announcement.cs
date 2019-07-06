namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Announcement")]
    public partial class Announcement
    {
        public long Id { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        [StringLength(500)]
        public string QueryString { get; set; }

        public string Description { get; set; }

        public string Contents { get; set; }

        public int? StatusId { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string Creator { get; set; }

        public DateTime? Modified { get; set; }

        [StringLength(50)]
        public string Modifier { get; set; }

        [StringLength(300)]
        public string FileAttach { get; set; }

        public DateTime? PublishedDate { get; set; }

        public DateTime? bEffectiveDate { get; set; }

        public DateTime? eEffectiveDate { get; set; }

        public bool? IsNew { get; set; }
    }
}
