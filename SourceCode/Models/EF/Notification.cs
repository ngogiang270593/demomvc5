namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Notification
    {
        public long Id { get; set; }

        [Column("_Create")]
        public DateTime? C_Create { get; set; }

        [Column("_Level")]
        public string C_Level { get; set; }

        public string Message { get; set; }

        [Column("_Read")]
        public string C_Read { get; set; }
    }
}
