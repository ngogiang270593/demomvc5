namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Question")]
    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            Answers = new HashSet<Answer>();
        }

        [Key]
        public long QAId { get; set; }

        [Column("Question")]
        public string Question1 { get; set; }

        [StringLength(500)]
        public string QueryString { get; set; }

        public DateTime? Created { get; set; }

        public int? MemberId { get; set; }

        public DateTime? Modified { get; set; }

        [StringLength(50)]
        public string Modifier { get; set; }

        public int? StatusID { get; set; }

        public long? Viewed { get; set; }

        public DateTime? PublishedDate { get; set; }

        public DateTime? bEffectiveDate { get; set; }

        public DateTime? eEffectiveDate { get; set; }

        public byte? IsExpert { get; set; }

        public int? ExpertId { get; set; }

        public long? Like { get; set; }

        public long? DisLike { get; set; }

        public long? DuAnId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
