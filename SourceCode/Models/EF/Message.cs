namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Message
    {
        public long Id { get; set; }

        public DateTime? Data { get; set; }

        public string Device { get; set; }

        public string Type { get; set; }

        [Column("Message")]
        public string Message1 { get; set; }

        public string Attachment { get; set; }
    }
}
