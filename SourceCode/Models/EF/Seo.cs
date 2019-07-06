namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Seo")]
    public partial class Seo
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Link { get; set; }

        public int? Sort { get; set; }

        public byte? StatusId { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string Creator { get; set; }

        public DateTime? Modified { get; set; }

        [StringLength(50)]
        public string Modifier { get; set; }

        [StringLength(1000)]
        public string FooterKeyword { get; set; }

        [StringLength(500)]
        public string MetaDes { get; set; }

        [StringLength(500)]
        public string MetaKeyword { get; set; }

        [StringLength(200)]
        public string MetaTitle { get; set; }

        [StringLength(1000)]
        public string TagClound { get; set; }

        [StringLength(200)]
        public string TitlePage { get; set; }
    }
}
