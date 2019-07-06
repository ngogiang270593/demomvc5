namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Unit")]
    public partial class Unit
    {
        public int Id { get; set; }

        public string TenCongTy { get; set; }

        public string DiaChi { get; set; }

        public string Email { get; set; }

        public string DienThoai { get; set; }

        public string TenCongTyEn { get; set; }

        public string DiaChiEn { get; set; }

        public string EmailEn { get; set; }

        public string DienThoaiEn { get; set; }

        public string SummaryEn { get; set; }

        public string SummaryVn { get; set; }

        public string Linkfb { get; set; }

        public string Linkyt { get; set; }

        public string Linkfanpage { get; set; }
    }
}
