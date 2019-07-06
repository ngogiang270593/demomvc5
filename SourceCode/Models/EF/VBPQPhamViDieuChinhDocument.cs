namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VBPQPhamViDieuChinhDocument")]
    public partial class VBPQPhamViDieuChinhDocument
    {
        public int Id { get; set; }

        public int? DocumentId { get; set; }

        public int? PhamViDieuChinhId { get; set; }

        public virtual VBPQDocument VBPQDocument { get; set; }

        public virtual VBPQPhamViDieuChinh VBPQPhamViDieuChinh { get; set; }
    }
}
