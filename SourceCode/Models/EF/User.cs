namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Products = new HashSet<Product>();
            Products1 = new HashSet<Product>();
            UsersMenus = new HashSet<UsersMenu>();
            UsersProvinces = new HashSet<UsersProvince>();
        }

        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public DateTime? LastLogin { get; set; }

        [StringLength(200)]
        public string FullName { get; set; }

        public byte IsUser { get; set; }

        public DateTime? Created { get; set; }

        public bool? IsActivated { get; set; }

        public bool? IsShowHome { get; set; }

        public int? Gender { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int? UserTypeId { get; set; }

        public bool? IsAdmin { get; set; }

        [StringLength(500)]
        public string DiaChi { get; set; }

        public int? ProvinceId { get; set; }

        public int? HuyenId { get; set; }

        public int? XaThiTranId { get; set; }

        [StringLength(50)]
        public string MobileOrther { get; set; }

        public int? ThoiHan { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public int? ChucVu { get; set; }

        public string Avatar { get; set; }

        public string MoTaVn { get; set; }

        public string MoTaEn { get; set; }

        public int? HienThiPortal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersMenu> UsersMenus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersProvince> UsersProvinces { get; set; }
    }
}
