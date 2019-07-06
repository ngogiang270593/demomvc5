namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StatusAction")]
    public partial class StatusAction
    {
        public int? CurrentStatusId { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string TitleHoSo { get; set; }

        public int? NextStatusId { get; set; }

        public int? Audit { get; set; }

        public int? FunctionId { get; set; }

        public int? ActionId { get; set; }

        public int Id { get; set; }

        public virtual Action Action { get; set; }

        public virtual SysFunction SysFunction { get; set; }
    }
}
