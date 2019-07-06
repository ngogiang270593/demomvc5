namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonViLienHe")]
    public partial class DonViLienHe
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public string Name { get; set; }

        public int? Sort { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(500)]
        public string Creator { get; set; }

        public DateTime? Modified { get; set; }

        [StringLength(500)]
        public string Modifier { get; set; }
    }
}
