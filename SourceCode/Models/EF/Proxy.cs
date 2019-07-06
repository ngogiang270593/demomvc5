namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Proxy")]
    public partial class Proxy
    {
        public int Id { get; set; }

        public string NguonProxy { get; set; }

        public string ProxySong { get; set; }

        public string QuocGiaProxy { get; set; }

        public string NgayCapNhatProxy { get; set; }

        public string MacMay { get; set; }

        public int? StatusId { get; set; }
    }
}
