namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Log")]
    public partial class Log
    {
        public int LogID { get; set; }

        public int FunctionID { get; set; }

        public DateTime? ActTime { get; set; }

        public int EventID { get; set; }

        [StringLength(200)]
        public string Content { get; set; }

        [StringLength(50)]
        public string ClientIP { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }
    }
}
