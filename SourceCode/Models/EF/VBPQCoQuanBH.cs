namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VBPQCoQuanBH")]
    public partial class VBPQCoQuanBH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VBPQCoQuanBH()
        {
            VBPQCoQuanBanHanhDocuments = new HashSet<VBPQCoQuanBanHanhDocument>();
        }

        public int Id { get; set; }

        [StringLength(1000)]
        public string CoQuanBH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VBPQCoQuanBanHanhDocument> VBPQCoQuanBanHanhDocuments { get; set; }
    }
}
