namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysHuongDan")]
    public partial class SysHuongDan
    {
        public long Id { get; set; }

        [StringLength(5000)]
        public string VIDEO { get; set; }

        [StringLength(5000)]
        public string DPF { get; set; }

        [StringLength(5000)]
        public string URL { get; set; }

        public string Name { get; set; }

        public int? Sort { get; set; }
    }
}
