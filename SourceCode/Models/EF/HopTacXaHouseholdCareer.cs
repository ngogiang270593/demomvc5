namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopTacXaHouseholdCareer")]
    public partial class HopTacXaHouseholdCareer
    {
        public int Id { get; set; }

        public long? HopTacXaID { get; set; }

        [StringLength(50)]
        public string HopTacXaCode { get; set; }

        [StringLength(50)]
        public string CareerCode { get; set; }

        [StringLength(400)]
        public string CareerName { get; set; }
    }
}
