namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Keyword")]
    public partial class Keyword
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Keyword()
        {
            ContentsKeywords = new HashSet<ContentsKeyword>();
        }

        public long KeywordID { get; set; }

        [Column("Keyword")]
        [StringLength(500)]
        public string Keyword1 { get; set; }

        public int? Viewed { get; set; }

        [StringLength(500)]
        public string QueryString { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContentsKeyword> ContentsKeywords { get; set; }
    }
}
