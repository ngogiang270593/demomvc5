namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            Products = new HashSet<Product>();
            StoreTypes = new HashSet<StoreType>();
        }

        [Key]
        public int CatId { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        [StringLength(500)]
        public string QueryString { get; set; }

        public int? ParentId { get; set; }

        public int? StatusId { get; set; }

        public double? Viewed { get; set; }

        public int? Sort { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string Creator { get; set; }

        public DateTime? Modified { get; set; }

        [StringLength(50)]
        public string Modifier { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(200)]
        public string LogoURL { get; set; }

        public bool? MainCate { get; set; }

        public int LanguageId { get; set; }

        [StringLength(50)]
        public string TitleEn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreType> StoreTypes { get; set; }
    }
}
