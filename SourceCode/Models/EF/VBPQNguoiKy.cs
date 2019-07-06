namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VBPQNguoiKy")]
    public partial class VBPQNguoiKy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VBPQNguoiKy()
        {
            VBPQChucDanhNguoiKies = new HashSet<VBPQChucDanhNguoiKy>();
        }

        public int Id { get; set; }

        [StringLength(1000)]
        public string NguoiKy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VBPQChucDanhNguoiKy> VBPQChucDanhNguoiKies { get; set; }
    }
}
