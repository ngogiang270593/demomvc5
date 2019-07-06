namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Action")]
    public partial class Action
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Action()
        {
            StatusActions = new HashSet<StatusAction>();
        }

        public int ActionId { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        public int FunctionId { get; set; }

        public int? AuditNumber { get; set; }

        public virtual SysFunction SysFunction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StatusAction> StatusActions { get; set; }
    }
}
