namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VBPQLoaiVanBan")]
    public partial class VBPQLoaiVanBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VBPQLoaiVanBan()
        {
            VBPQDocuments = new HashSet<VBPQDocument>();
        }

        public int ID { get; set; }

        [StringLength(1000)]
        public string LoaiVanBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VBPQDocument> VBPQDocuments { get; set; }
    }
}
