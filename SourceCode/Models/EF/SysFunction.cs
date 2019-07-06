namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysFunction")]
    public partial class SysFunction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SysFunction()
        {
            Actions = new HashSet<Action>();
            Status = new HashSet<Status>();
            StatusActions = new HashSet<StatusAction>();
            SysFuncRolesStatusPermissions = new HashSet<SysFuncRolesStatusPermission>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FunctionId { get; set; }

        [StringLength(500)]
        public string FunctionName { get; set; }

        [StringLength(300)]
        public string URL { get; set; }

        public bool? IsMenu { get; set; }

        public bool? IsStatus { get; set; }

        public int? LanguageId { get; set; }

        public bool IsShow { get; set; }

        [StringLength(200)]
        public string HrefName { get; set; }

        public int? ParentId { get; set; }

        public int? Sort { get; set; }

        public int? IsHoSo { get; set; }

        [StringLength(500)]
        public string icons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Action> Actions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Status> Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StatusAction> StatusActions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SysFuncRolesStatusPermission> SysFuncRolesStatusPermissions { get; set; }
    }
}
