namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TraoDoiNghiepVuTraLoiActionHistory")]
    public partial class TraoDoiNghiepVuTraLoiActionHistory
    {
        public long Id { get; set; }

        public int? FunctionId { get; set; }

        public int? ObjId { get; set; }

        [StringLength(50)]
        public string Creator { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? PublishedDate { get; set; }

        public DateTime? eEffectiveDate { get; set; }

        public byte? CurrentStatusId { get; set; }

        public byte? ActionStatusId { get; set; }

        public string Note { get; set; }
    }
}
