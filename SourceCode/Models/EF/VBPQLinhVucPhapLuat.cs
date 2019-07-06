namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VBPQLinhVucPhapLuat")]
    public partial class VBPQLinhVucPhapLuat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VBPQLinhVucPhapLuat()
        {
            VBPQLinhVucPhapLuatDocuments = new HashSet<VBPQLinhVucPhapLuatDocument>();
        }

        public int Id { get; set; }

        [StringLength(1000)]
        public string LinhVuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VBPQLinhVucPhapLuatDocument> VBPQLinhVucPhapLuatDocuments { get; set; }
    }
}
