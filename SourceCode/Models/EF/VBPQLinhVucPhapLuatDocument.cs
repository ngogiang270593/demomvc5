namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VBPQLinhVucPhapLuatDocument")]
    public partial class VBPQLinhVucPhapLuatDocument
    {
        public int Id { get; set; }

        public int? DocumentId { get; set; }

        public int? LinhVucPhapLuatId { get; set; }

        public virtual VBPQDocument VBPQDocument { get; set; }

        public virtual VBPQLinhVucPhapLuat VBPQLinhVucPhapLuat { get; set; }
    }
}
