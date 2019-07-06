namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TraoDoiNghiepVuCauHoi")]
    public partial class TraoDoiNghiepVuCauHoi
    {
        public long Id { get; set; }

        public string Title { get; set; }

        [StringLength(500)]
        public string QueryString { get; set; }

        public string Description { get; set; }

        public string Contents { get; set; }

        [StringLength(200)]
        public string Author { get; set; }

        public int? StatusId { get; set; }

        public int? MenuId { get; set; }

        public bool? IsHot { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string Creator { get; set; }

        public DateTime? Modified { get; set; }

        [StringLength(50)]
        public string Modifier { get; set; }

        [StringLength(300)]
        public string Image { get; set; }

        public DateTime? PublishedDate { get; set; }

        public DateTime? bEffectiveDate { get; set; }

        public DateTime? eEffectiveDate { get; set; }

        public bool? IsNew { get; set; }

        [StringLength(300)]
        public string Subject { get; set; }

        [StringLength(1000)]
        public string Keyword { get; set; }

        public int? Like { get; set; }

        public int? DisLike { get; set; }

        public int? Viewed { get; set; }

        public int? TypeId { get; set; }

        [StringLength(3000)]
        public string URL { get; set; }

        public bool? IsYoutube { get; set; }

        [StringLength(300)]
        public string ImageBig { get; set; }

        public int LanguageId { get; set; }

        public int? SoCauHoi { get; set; }

        public virtual Menu Menu { get; set; }
    }
}
