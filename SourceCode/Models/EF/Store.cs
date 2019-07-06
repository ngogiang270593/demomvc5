namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Store")]
    public partial class Store
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Store()
        {
            StoreImages = new HashSet<StoreImage>();
            StoreTypes = new HashSet<StoreType>();
        }

        public int StoreId { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(200)]
        public string QueryString { get; set; }

        [StringLength(500)]
        public string Slogan { get; set; }

        public string Description { get; set; }

        public string ContactUs { get; set; }

        [Required]
        [StringLength(300)]
        public string URLWEB { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(300)]
        public string ImgLogo { get; set; }

        public int? StoreTypeId { get; set; }

        public int? UserId { get; set; }

        public double? Viewed { get; set; }

        public double? Mark { get; set; }

        public int? TotalVote { get; set; }

        public bool? IsHot { get; set; }

        public int? StatusId { get; set; }

        public DateTime? bEffectiveDate { get; set; }

        public DateTime? PublishedDate { get; set; }

        public DateTime? eEffectiveDate { get; set; }

        [StringLength(300)]
        public string BigBanner { get; set; }

        [StringLength(300)]
        public string ImageSlider { get; set; }

        [StringLength(50)]
        public string YahooId { get; set; }

        [StringLength(50)]
        public string SkypeId { get; set; }

        public int? TinhThanhId { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(500)]
        public string DiaChi { get; set; }

        [StringLength(200)]
        public string HoTen { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string PhoneOther { get; set; }

        public bool? IsVip { get; set; }

        [StringLength(500)]
        public string HeaderImage { get; set; }

        public string Map { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreImage> StoreImages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreType> StoreTypes { get; set; }
    }
}
