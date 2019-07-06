namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            ProductAdjusts = new HashSet<ProductAdjust>();
            ProductImages = new HashSet<ProductImage>();
        }

        public long ProductId { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        [StringLength(500)]
        public string QueryString { get; set; }

        public string Description { get; set; }

        [StringLength(500)]
        public string ImagePreview { get; set; }

        public double? OriginalPrice { get; set; }

        public double? SellPrice { get; set; }

        public int? StoreId { get; set; }

        public double? Viewed { get; set; }

        public DateTime? Created { get; set; }

        public int? CreatorId { get; set; }

        public DateTime? Modified { get; set; }

        public int? ModifierId { get; set; }

        public bool? IsSellOff { get; set; }

        public bool? IsHot { get; set; }

        public int? StatusId { get; set; }

        public DateTime? bEffectiveDate { get; set; }

        public DateTime? PublishedDate { get; set; }

        public DateTime? eEffectiveDate { get; set; }

        public int? CateID { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public int? DaBan { get; set; }

        public int? TinhTrangHang { get; set; }

        public int? TongSo { get; set; }

        [StringLength(200)]
        public string XuatXu { get; set; }

        public int? TinhTP { get; set; }

        [StringLength(500)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string PhoneOther { get; set; }

        [StringLength(200)]
        public string HoTen { get; set; }

        [StringLength(50)]
        public string YahooId { get; set; }

        [StringLength(50)]
        public string SkypeId { get; set; }

        [StringLength(50)]
        public string WebUrl { get; set; }

        public int LanguageId { get; set; }

        public int ProductUnitId { get; set; }

        public virtual Category Category { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductAdjust> ProductAdjusts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}
