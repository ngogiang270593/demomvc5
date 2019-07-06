namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Device
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        public string Name { get; set; }

        public string IMEI { get; set; }

        public string Password { get; set; }

        public string Last_data_received { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string Height_above_sea_level { get; set; }

        public string Timezone_ID { get; set; }

        public string Load_forecast { get; set; }

        public string Integration_with_ExactFarming { get; set; }

        public string Parameter { get; set; }
    }
}
