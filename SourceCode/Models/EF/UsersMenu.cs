namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsersMenu")]
    public partial class UsersMenu
    {
        public int ID { get; set; }

        public int UserId { get; set; }

        public int MenuId { get; set; }

        public virtual Menu Menu { get; set; }

        public virtual User User { get; set; }
    }
}
