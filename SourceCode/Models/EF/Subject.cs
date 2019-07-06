namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Subject")]
    public partial class Subject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subject()
        {
            ContentsSubjects = new HashSet<ContentsSubject>();
        }

        public long SubjectId { get; set; }

        [Column("Subject")]
        [Required]
        [StringLength(500)]
        public string Subject1 { get; set; }

        [StringLength(500)]
        public string QueryString { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContentsSubject> ContentsSubjects { get; set; }
    }
}
