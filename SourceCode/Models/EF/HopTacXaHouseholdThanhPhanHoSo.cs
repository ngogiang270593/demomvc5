namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopTacXaHouseholdThanhPhanHoSo")]
    public partial class HopTacXaHouseholdThanhPhanHoSo
    {
        public int? ThanhPhanHoSoId { get; set; }

        public long? HopTacXaID { get; set; }

        public int Id { get; set; }
    }
}
