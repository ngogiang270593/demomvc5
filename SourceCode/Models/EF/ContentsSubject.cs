namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContentsSubject")]
    public partial class ContentsSubject
    {
        public long ContentId { get; set; }

        public long SubjectId { get; set; }

        public int id { get; set; }

        public virtual Content Content { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
