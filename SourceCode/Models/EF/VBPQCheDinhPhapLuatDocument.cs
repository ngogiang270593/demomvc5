namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VBPQCheDinhPhapLuatDocument")]
    public partial class VBPQCheDinhPhapLuatDocument
    {
        public int Id { get; set; }

        public int? DocumentId { get; set; }

        public int? CheDinhPhapLuatId { get; set; }

        public virtual VBPQCheDinhPhapLuat VBPQCheDinhPhapLuat { get; set; }

        public virtual VBPQDocument VBPQDocument { get; set; }
    }
}
