namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VBPQCheDinhPhapLuat")]
    public partial class VBPQCheDinhPhapLuat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VBPQCheDinhPhapLuat()
        {
            VBPQCheDinhPhapLuatDocuments = new HashSet<VBPQCheDinhPhapLuatDocument>();
        }

        public int Id { get; set; }

        [StringLength(1000)]
        public string CheDinhPhapLuat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VBPQCheDinhPhapLuatDocument> VBPQCheDinhPhapLuatDocuments { get; set; }
    }
}
