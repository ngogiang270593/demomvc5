namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopTacXaHouseholdNganhNghe")]
    public partial class HopTacXaHouseholdNganhNghe
    {
        public int Id { get; set; }

        public long? HopTacXaID { get; set; }

        public int? DanhMucNganhNgheID { get; set; }

        public string Description { get; set; }
    }
}
