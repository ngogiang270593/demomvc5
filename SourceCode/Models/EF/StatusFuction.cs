namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StatusFuction")]
    public partial class StatusFuction
    {
        public int? StatusId { get; set; }

        public int? FunctioncId { get; set; }

        public int Id { get; set; }
    }
}
