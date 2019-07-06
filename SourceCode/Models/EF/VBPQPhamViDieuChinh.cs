namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VBPQPhamViDieuChinh")]
    public partial class VBPQPhamViDieuChinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VBPQPhamViDieuChinh()
        {
            VBPQPhamViDieuChinhDocuments = new HashSet<VBPQPhamViDieuChinhDocument>();
        }

        public int Id { get; set; }

        [StringLength(1000)]
        public string PhamViDieuChinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VBPQPhamViDieuChinhDocument> VBPQPhamViDieuChinhDocuments { get; set; }
    }
}
