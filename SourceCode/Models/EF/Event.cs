namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string EventName { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
    }
}
