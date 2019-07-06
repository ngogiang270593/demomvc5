namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VBPQVanBanThayThe")]
    public partial class VBPQVanBanThayThe
    {
        public int ID { get; set; }

        public int? VanBanThayTheId { get; set; }

        public int? DocumentId { get; set; }
    }
}
