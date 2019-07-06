namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VBPQVanBanCanCu")]
    public partial class VBPQVanBanCanCu
    {
        public int? DocumentId { get; set; }

        public int? VanBanCanCuId { get; set; }

        public int Id { get; set; }
    }
}
