namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopTacXaHouseholdAddress")]
    public partial class HopTacXaHouseholdAddress
    {
        public int Id { get; set; }

        public long? HopTacXaID { get; set; }

        public int? TypeId { get; set; }

        [StringLength(200)]
        public string Adress { get; set; }

        public int? XaThiTranId { get; set; }

        public int? HuyenId { get; set; }

        public int? TinhId { get; set; }
    }
}
