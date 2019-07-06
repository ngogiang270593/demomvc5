namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopTacXaHouseholdChangingType")]
    public partial class HopTacXaHouseholdChangingType
    {
        public int Id { get; set; }

        public int? ChangingTypeiId { get; set; }

        public long? HopTacXaID { get; set; }
    }
}
