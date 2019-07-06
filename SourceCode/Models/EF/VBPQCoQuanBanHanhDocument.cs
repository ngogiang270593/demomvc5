namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VBPQCoQuanBanHanhDocument")]
    public partial class VBPQCoQuanBanHanhDocument
    {
        public int Id { get; set; }

        public int? CoQuanBanHanh { get; set; }

        public int? DocumentId { get; set; }

        public virtual VBPQCoQuanBH VBPQCoQuanBH { get; set; }

        public virtual VBPQDocument VBPQDocument { get; set; }
    }
}
