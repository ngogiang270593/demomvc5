namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopTacXaHouseholdDonViLienHe")]
    public partial class HopTacXaHouseholdDonViLienHe
    {
        public int Id { get; set; }

        public long? HopTacXaID { get; set; }

        public int? DonViLienHeId { get; set; }
    }
}
