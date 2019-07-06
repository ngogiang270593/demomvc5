namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Menu()
        {
            Contents = new HashSet<Content>();
            TraoDoiNghiepVuCauHois = new HashSet<TraoDoiNghiepVuCauHoi>();
            TraoDoiNghiepVuTraLois = new HashSet<TraoDoiNghiepVuTraLoi>();
            UsersMenus = new HashSet<UsersMenu>();
        }

        public int MenuId { get; set; }

        [StringLength(300)]
        public string Title { get; set; }

        [StringLength(500)]
        public string TitleEn { get; set; }

        public string Description { get; set; }

        public int? Sort { get; set; }

        [StringLength(5)]
        public string MenuPosition { get; set; }

        public byte? StatusId { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string Creator { get; set; }

        public DateTime? Modified { get; set; }

        [StringLength(50)]
        public string Modifier { get; set; }

        public DateTime? bEffectiveDate { get; set; }

        public DateTime? eEffectiveDate { get; set; }

        public int? ParentId { get; set; }

        public DateTime? PublishedDate { get; set; }

        [StringLength(300)]
        public string QueryString { get; set; }

        [StringLength(300)]
        public string NavigateUrl { get; set; }

        public byte? ShowRight { get; set; }

        public string TitlePage { get; set; }

        public int LanguageId { get; set; }

        [StringLength(500)]
        public string ImageLogo { get; set; }

        public string ImageTitle { get; set; }

        public string DescriptionEn { get; set; }

        public string Summary { get; set; }

        [StringLength(500)]
        public string IconTieuChi { get; set; }

        public string SummaryEn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Content> Contents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TraoDoiNghiepVuCauHoi> TraoDoiNghiepVuCauHois { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TraoDoiNghiepVuTraLoi> TraoDoiNghiepVuTraLois { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersMenu> UsersMenus { get; set; }
    }
}
