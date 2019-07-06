namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Province")]
    public partial class Province
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Province()
        {
            DeptCertifieds = new HashSet<DeptCertified>();
            StaffDicts = new HashSet<StaffDict>();
            UsersProvinces = new HashSet<UsersProvince>();
        }

        public int Id { get; set; }

        public int? CodeId { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(50)]
        public string MainTinhThanh { get; set; }

        public int? ParentId { get; set; }

        public int? Sort { get; set; }

        [StringLength(200)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string DienThoai { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Website { get; set; }

        public int? SoNgayTraHoSo { get; set; }

        [StringLength(3000)]
        public string BienNhan { get; set; }

        [StringLength(50)]
        public string GioBienNhan { get; set; }

        [StringLength(500)]
        public string MaCoQuanThue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeptCertified> DeptCertifieds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffDict> StaffDicts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersProvince> UsersProvinces { get; set; }
    }
}
