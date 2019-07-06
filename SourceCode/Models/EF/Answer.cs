namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Answer")]
    public partial class Answer
    {
        public long AnswerId { get; set; }

        public long QAId { get; set; }

        [Column("Answer")]
        public string Answer1 { get; set; }

        public int? StatusId { get; set; }

        public int? MemberId { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string Modifier { get; set; }

        public DateTime? Modified { get; set; }

        public long? Viewed { get; set; }

        public long? Like { get; set; }

        public long? DisLike { get; set; }

        public DateTime? PublishedDate { get; set; }

        public DateTime? eEffectiveDate { get; set; }

        public virtual Question Question { get; set; }
    }
}
