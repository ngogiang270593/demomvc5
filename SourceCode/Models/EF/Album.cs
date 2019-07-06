namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Album")]
    public partial class Album
    {
        public int AlbumID { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        public int ContensID { get; set; }
    }
}
