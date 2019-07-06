namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VBPQChucDanhNguoiKy")]
    public partial class VBPQChucDanhNguoiKy
    {
        public int Id { get; set; }

        public int? NguoiKyId { get; set; }

        public int? ChucDanhId { get; set; }

        public int? DocumentId { get; set; }

        public virtual VBPQChucDanh VBPQChucDanh { get; set; }

        public virtual VBPQDocument VBPQDocument { get; set; }

        public virtual VBPQNguoiKy VBPQNguoiKy { get; set; }
    }
}
