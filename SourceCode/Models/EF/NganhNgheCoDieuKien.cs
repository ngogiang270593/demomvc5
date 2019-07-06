namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NganhNgheCoDieuKien")]
    public partial class NganhNgheCoDieuKien
    {
        public int Id { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        [StringLength(500)]
        public string QueryString { get; set; }

        public string NoiDung { get; set; }

        [StringLength(500)]
        public string VanBanHuongDan { get; set; }

        [StringLength(500)]
        public string FileDinhkem { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string Creator { get; set; }

        public DateTime? Modified { get; set; }

        [StringLength(50)]
        public string Modifier { get; set; }

        public DateTime? PublishedDate { get; set; }

        public DateTime? bEffectiveDate { get; set; }

        public DateTime? eEffectiveDate { get; set; }

        public int? StatusId { get; set; }
    }
}
