namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfigTheme")]
    public partial class ConfigTheme
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        [StringLength(2000)]
        public string SidebarColor { get; set; }

        [StringLength(2000)]
        public string HeaderBrandColor { get; set; }

        [StringLength(2000)]
        public string HeaderColor { get; set; }

        [StringLength(2000)]
        public string SidebarPostion { get; set; }

        [StringLength(2000)]
        public string Header { get; set; }

        [StringLength(2000)]
        public string SidebarMenu { get; set; }

        [StringLength(2000)]
        public string Footer { get; set; }
    }
}
