namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Poll")]
    public partial class Poll
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PollID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(500)]
        public string Question { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string BlockMode { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Active { get; set; }

        [StringLength(50)]
        public string PollOption { get; set; }

        public long? ContentId { get; set; }

        public byte? StatusId { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string Creator { get; set; }

        public DateTime? Modified { get; set; }

        [StringLength(50)]
        public string Modifier { get; set; }

        public DateTime? bEffectiveDate { get; set; }

        public DateTime? eEffectiveDate { get; set; }

        public DateTime? PublishedDate { get; set; }
    }
}
