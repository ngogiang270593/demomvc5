namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VBPQVanBanSuaDoi")]
    public partial class VBPQVanBanSuaDoi
    {
        public int ID { get; set; }

        public int? VanBanSuaDoiId { get; set; }

        public int? DocumentId { get; set; }
    }
}
