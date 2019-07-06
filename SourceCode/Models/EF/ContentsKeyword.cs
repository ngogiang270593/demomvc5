namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContentsKeyword")]
    public partial class ContentsKeyword
    {
        public long ContentId { get; set; }

        public long KeywordId { get; set; }

        public int id { get; set; }

        public virtual Content Content { get; set; }

        public virtual Keyword Keyword { get; set; }
    }
}
