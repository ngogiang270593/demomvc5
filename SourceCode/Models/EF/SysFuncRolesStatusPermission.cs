namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysFuncRolesStatusPermission")]
    public partial class SysFuncRolesStatusPermission
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FunctionId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleId { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte StatusId { get; set; }

        public int? AuditNumber { get; set; }

        public virtual Role Role { get; set; }

        public virtual SysFunction SysFunction { get; set; }
    }
}
