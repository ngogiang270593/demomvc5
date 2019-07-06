namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImagesAdver")]
    public partial class ImagesAdver
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(500)]
        public string SRC { get; set; }

        [StringLength(500)]
        public string URL { get; set; }

        public int? Subject { get; set; }

        public int? StatusID { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string Creator { get; set; }

        public DateTime? Modified { get; set; }

        [StringLength(50)]
        public string Modifier { get; set; }

        public int? Sort { get; set; }

        public int LanguageID { get; set; }
    }
}
