namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HolidayCalendar")]
    public partial class HolidayCalendar
    {
        [Key]
        public int CalendarId { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        [StringLength(100)]
        public string Ref1 { get; set; }

        [StringLength(100)]
        public string Ref2 { get; set; }
    }
}
