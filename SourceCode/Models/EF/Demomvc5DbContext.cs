namespace Models.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Demomvc5DbContext : DbContext
    {
        public Demomvc5DbContext()
            : base("name=Demomvc5")
        {
        }

        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Announcement> Announcements { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<BusinessField> BusinessFields { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CertifiedChamDut> CertifiedChamDuts { get; set; }
        public virtual DbSet<CertifiedHousehold> CertifiedHouseholds { get; set; }
        public virtual DbSet<CertifiedHouseholdAddress> CertifiedHouseholdAddresses { get; set; }
        public virtual DbSet<CertifiedHouseholdCareer> CertifiedHouseholdCareers { get; set; }
        public virtual DbSet<CertifiedHouseholdChangingType> CertifiedHouseholdChangingTypes { get; set; }
        public virtual DbSet<CertifiedHouseholdDonViLienHe> CertifiedHouseholdDonViLienHes { get; set; }
        public virtual DbSet<CertifiedHouseholdMember> CertifiedHouseholdMembers { get; set; }
        public virtual DbSet<CertifiedHouseholdNganhNghe> CertifiedHouseholdNganhNghes { get; set; }
        public virtual DbSet<CertifiedHouseholdThanhPhanHoSo> CertifiedHouseholdThanhPhanHoSoes { get; set; }
        public virtual DbSet<CertifiedHouseProfileCoQuan> CertifiedHouseProfileCoQuans { get; set; }
        public virtual DbSet<CertifiedHouseQuyetDinh> CertifiedHouseQuyetDinhs { get; set; }
        public virtual DbSet<CertifiedHouseThongBao> CertifiedHouseThongBaos { get; set; }
        public virtual DbSet<CertifiedPaperDict> CertifiedPaperDicts { get; set; }
        public virtual DbSet<CertifiedTamNgung> CertifiedTamNgungs { get; set; }
        public virtual DbSet<ChangingType> ChangingTypes { get; set; }
        public virtual DbSet<ChotTinhHinhThucHien> ChotTinhHinhThucHiens { get; set; }
        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<Config> Configs { get; set; }
        public virtual DbSet<ConfigTheme> ConfigThemes { get; set; }
        public virtual DbSet<ContentActionHistory> ContentActionHistories { get; set; }
        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<ContentsKeyword> ContentsKeywords { get; set; }
        public virtual DbSet<ContentsSubject> ContentsSubjects { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<DanhBaTCKHHuyen> DanhBaTCKHHuyens { get; set; }
        public virtual DbSet<DanhMucNganhNghe> DanhMucNganhNghes { get; set; }
        public virtual DbSet<DeptCertified> DeptCertifieds { get; set; }
        public virtual DbSet<DeptIdentify> DeptIdentifies { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<DonViLienHe> DonViLienHes { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<HitCounter> HitCounters { get; set; }
        public virtual DbSet<HolidayCalendar> HolidayCalendars { get; set; }
        public virtual DbSet<HopTacXaChamDut> HopTacXaChamDuts { get; set; }
        public virtual DbSet<HopTacXaHousehold> HopTacXaHouseholds { get; set; }
        public virtual DbSet<HopTacXaHouseholdAddress> HopTacXaHouseholdAddresses { get; set; }
        public virtual DbSet<HopTacXaHouseholdCareer> HopTacXaHouseholdCareers { get; set; }
        public virtual DbSet<HopTacXaHouseholdChangingType> HopTacXaHouseholdChangingTypes { get; set; }
        public virtual DbSet<HopTacXaHouseholdDonViLienHe> HopTacXaHouseholdDonViLienHes { get; set; }
        public virtual DbSet<HopTacXaHouseholdMember> HopTacXaHouseholdMembers { get; set; }
        public virtual DbSet<HopTacXaHouseholdNganhNghe> HopTacXaHouseholdNganhNghes { get; set; }
        public virtual DbSet<HopTacXaHouseholdThanhPhanHoSo> HopTacXaHouseholdThanhPhanHoSoes { get; set; }
        public virtual DbSet<HopTacXaHouseProfileCoQuan> HopTacXaHouseProfileCoQuans { get; set; }
        public virtual DbSet<HopTacXaHouseQuyetDinh> HopTacXaHouseQuyetDinhs { get; set; }
        public virtual DbSet<HopTacXaHouseThongBao> HopTacXaHouseThongBaos { get; set; }
        public virtual DbSet<HopTacXaPaperDict> HopTacXaPaperDicts { get; set; }
        public virtual DbSet<HopTacXaTamNgung> HopTacXaTamNgungs { get; set; }
        public virtual DbSet<HoSoMoiAGESB> HoSoMoiAGESBs { get; set; }
        public virtual DbSet<ImagesAdver> ImagesAdvers { get; set; }
        public virtual DbSet<Keyword> Keywords { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<LogLogin> LogLogins { get; set; }
        public virtual DbSet<MappingProvince> MappingProvinces { get; set; }
        public virtual DbSet<MappingStatu> MappingStatus { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<NganhNgheCoDieuKien> NganhNgheCoDieuKiens { get; set; }
        public virtual DbSet<NguoiNopThue> NguoiNopThues { get; set; }
        public virtual DbSet<NopThue> NopThues { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<OtherList> OtherLists { get; set; }
        public virtual DbSet<Partner> Partners { get; set; }
        public virtual DbSet<PositionDict> PositionDicts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductAdjust> ProductAdjusts { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<ProductUnit> ProductUnits { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Proxy> Proxies { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<RoleMenu> RoleMenus { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Seo> Seos { get; set; }
        public virtual DbSet<StaffDict> StaffDicts { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<StatusAction> StatusActions { get; set; }
        public virtual DbSet<StatusFuction> StatusFuctions { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<StoreImage> StoreImages { get; set; }
        public virtual DbSet<StoreType> StoreTypes { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<SYS_PARAMETERS> SYS_PARAMETERS { get; set; }
        public virtual DbSet<SysFuncRolesStatusPermission> SysFuncRolesStatusPermissions { get; set; }
        public virtual DbSet<SysFunction> SysFunctions { get; set; }
        public virtual DbSet<SysHuongDan> SysHuongDans { get; set; }
        public virtual DbSet<ThanhPhanHoSo> ThanhPhanHoSoes { get; set; }
        public virtual DbSet<ToDoList> ToDoLists { get; set; }
        public virtual DbSet<TraoDoiNghiepVuCauHoi> TraoDoiNghiepVuCauHois { get; set; }
        public virtual DbSet<TraoDoiNghiepVuCauHoiActionHistory> TraoDoiNghiepVuCauHoiActionHistories { get; set; }
        public virtual DbSet<TraoDoiNghiepVuTraLoi> TraoDoiNghiepVuTraLois { get; set; }
        public virtual DbSet<TraoDoiNghiepVuTraLoiActionHistory> TraoDoiNghiepVuTraLoiActionHistories { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<UserCauHoi> UserCauHois { get; set; }
        public virtual DbSet<UserCauHoiFileDinhKem> UserCauHoiFileDinhKems { get; set; }
        public virtual DbSet<UserMailTraLoi> UserMailTraLois { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsersMenu> UsersMenus { get; set; }
        public virtual DbSet<UsersProvince> UsersProvinces { get; set; }
        public virtual DbSet<UserThanhPhanHoSo> UserThanhPhanHoSoes { get; set; }
        public virtual DbSet<UserTraLoiCauHoi> UserTraLoiCauHois { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<VBPQCheDinhPhapLuat> VBPQCheDinhPhapLuats { get; set; }
        public virtual DbSet<VBPQCheDinhPhapLuatDocument> VBPQCheDinhPhapLuatDocuments { get; set; }
        public virtual DbSet<VBPQChucDanh> VBPQChucDanhs { get; set; }
        public virtual DbSet<VBPQChucDanhNguoiKy> VBPQChucDanhNguoiKies { get; set; }
        public virtual DbSet<VBPQCoQuanBanHanhDocument> VBPQCoQuanBanHanhDocuments { get; set; }
        public virtual DbSet<VBPQCoQuanBH> VBPQCoQuanBHs { get; set; }
        public virtual DbSet<VBPQDocument> VBPQDocuments { get; set; }
        public virtual DbSet<VBPQLinhVucPhapLuat> VBPQLinhVucPhapLuats { get; set; }
        public virtual DbSet<VBPQLinhVucPhapLuatDocument> VBPQLinhVucPhapLuatDocuments { get; set; }
        public virtual DbSet<VBPQLoaiVanBan> VBPQLoaiVanBans { get; set; }
        public virtual DbSet<VBPQNguoiKy> VBPQNguoiKies { get; set; }
        public virtual DbSet<VBPQPhamViDieuChinh> VBPQPhamViDieuChinhs { get; set; }
        public virtual DbSet<VBPQPhamViDieuChinhDocument> VBPQPhamViDieuChinhDocuments { get; set; }
        public virtual DbSet<VBPQVanBanCanCu> VBPQVanBanCanCus { get; set; }
        public virtual DbSet<VBPQVanBanDanChieu> VBPQVanBanDanChieux { get; set; }
        public virtual DbSet<VBPQVanBanSuaDoi> VBPQVanBanSuaDois { get; set; }
        public virtual DbSet<VBPQVanBanThayThe> VBPQVanBanThayThes { get; set; }
        public virtual DbSet<Ward> Wards { get; set; }
        public virtual DbSet<OtherListTable> OtherListTables { get; set; }
        public virtual DbSet<Poll> Polls { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Announcement>()
                .Property(e => e.FileAttach)
                .IsUnicode(false);

            modelBuilder.Entity<Answer>()
                .Property(e => e.Modifier)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Creator)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Modifier)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Category)
                .HasForeignKey(e => e.CateID);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.StoreTypes)
                .WithOptional(e => e.Category)
                .HasForeignKey(e => e.RootCateId);

            modelBuilder.Entity<CertifiedHousehold>()
                .Property(e => e.Biz_Tel)
                .IsUnicode(false);

            modelBuilder.Entity<CertifiedHousehold>()
                .Property(e => e.Biz_Fax)
                .IsUnicode(false);

            modelBuilder.Entity<CertifiedHousehold>()
                .Property(e => e.Biz_Email)
                .IsUnicode(false);

            modelBuilder.Entity<CertifiedHousehold>()
                .Property(e => e.Biz_Website)
                .IsUnicode(false);

            modelBuilder.Entity<CertifiedHousehold>()
                .Property(e => e.Ow_BirthDate)
                .IsUnicode(false);

            modelBuilder.Entity<CertifiedHousehold>()
                .Property(e => e.Ow_Tel)
                .IsUnicode(false);

            modelBuilder.Entity<CertifiedHousehold>()
                .Property(e => e.Ow_Fax)
                .IsUnicode(false);

            modelBuilder.Entity<CertifiedHousehold>()
                .Property(e => e.Ow_Email)
                .IsUnicode(false);

            modelBuilder.Entity<CertifiedHousehold>()
                .Property(e => e.Ow_WebSite)
                .IsUnicode(false);

            modelBuilder.Entity<CertifiedHousehold>()
                .Property(e => e.CertifiedStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CertifiedHousehold>()
                .Property(e => e.Properties_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CertifiedHousehold>()
                .Property(e => e.Files_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CertifiedHouseQuyetDinh>()
                .Property(e => e.CanCu)
                .IsUnicode(false);

            modelBuilder.Entity<ChotTinhHinhThucHien>()
                .Property(e => e.LoaiCap)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigTheme>()
                .Property(e => e.SidebarColor)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigTheme>()
                .Property(e => e.HeaderBrandColor)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigTheme>()
                .Property(e => e.HeaderColor)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigTheme>()
                .Property(e => e.SidebarPostion)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigTheme>()
                .Property(e => e.Header)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigTheme>()
                .Property(e => e.SidebarMenu)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigTheme>()
                .Property(e => e.Footer)
                .IsUnicode(false);

            modelBuilder.Entity<ContentActionHistory>()
                .Property(e => e.Creator)
                .IsUnicode(false);

            modelBuilder.Entity<Content>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Content>()
                .Property(e => e.ImageBig)
                .IsUnicode(false);

            modelBuilder.Entity<Content>()
                .Property(e => e.IconTieuChi)
                .IsUnicode(false);

            modelBuilder.Entity<Content>()
                .HasMany(e => e.ContentsKeywords)
                .WithRequired(e => e.Content)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Content>()
                .HasMany(e => e.ContentsSubjects)
                .WithRequired(e => e.Content)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DanhBaTCKHHuyen>()
                .Property(e => e.DienThoaiBan)
                .IsUnicode(false);

            modelBuilder.Entity<DanhBaTCKHHuyen>()
                .Property(e => e.DienThoaiDiDong)
                .IsUnicode(false);

            modelBuilder.Entity<DanhBaTCKHHuyen>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Device>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HopTacXaHousehold>()
                .Property(e => e.Biz_Tel)
                .IsUnicode(false);

            modelBuilder.Entity<HopTacXaHousehold>()
                .Property(e => e.Biz_Fax)
                .IsUnicode(false);

            modelBuilder.Entity<HopTacXaHousehold>()
                .Property(e => e.Biz_Email)
                .IsUnicode(false);

            modelBuilder.Entity<HopTacXaHousehold>()
                .Property(e => e.Biz_Website)
                .IsUnicode(false);

            modelBuilder.Entity<HopTacXaHousehold>()
                .Property(e => e.Ow_BirthDate)
                .IsUnicode(false);

            modelBuilder.Entity<HopTacXaHousehold>()
                .Property(e => e.Ow_Tel)
                .IsUnicode(false);

            modelBuilder.Entity<HopTacXaHousehold>()
                .Property(e => e.Ow_Fax)
                .IsUnicode(false);

            modelBuilder.Entity<HopTacXaHousehold>()
                .Property(e => e.Ow_Email)
                .IsUnicode(false);

            modelBuilder.Entity<HopTacXaHousehold>()
                .Property(e => e.Ow_WebSite)
                .IsUnicode(false);

            modelBuilder.Entity<HopTacXaHousehold>()
                .Property(e => e.HopTacXaStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HopTacXaHousehold>()
                .Property(e => e.Properties_ID)
                .IsUnicode(false);

            modelBuilder.Entity<HopTacXaHousehold>()
                .Property(e => e.Files_ID)
                .IsUnicode(false);

            modelBuilder.Entity<HopTacXaHouseQuyetDinh>()
                .Property(e => e.CanCu)
                .IsUnicode(false);

            modelBuilder.Entity<ImagesAdver>()
                .Property(e => e.SRC)
                .IsUnicode(false);

            modelBuilder.Entity<ImagesAdver>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<Keyword>()
                .HasMany(e => e.ContentsKeywords)
                .WithRequired(e => e.Keyword)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MappingProvince>()
                .Property(e => e.ProvinceIdMC)
                .IsFixedLength();

            modelBuilder.Entity<MappingProvince>()
                .Property(e => e.ProvinceIdDKHKD)
                .IsFixedLength();

            modelBuilder.Entity<MappingStatu>()
                .Property(e => e.StatusIdMC)
                .IsFixedLength();

            modelBuilder.Entity<MappingStatu>()
                .Property(e => e.StatusIdDKHKD)
                .IsFixedLength();

            modelBuilder.Entity<Menu>()
                .HasMany(e => e.UsersMenus)
                .WithRequired(e => e.Menu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NopThue>()
                .Property(e => e.Creator)
                .IsFixedLength();

            modelBuilder.Entity<Partner>()
                .Property(e => e.SRC)
                .IsUnicode(false);

            modelBuilder.Entity<Partner>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductAdjusts)
                .WithOptional(e => e.Product)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductImages)
                .WithOptional(e => e.Product)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Province>()
                .Property(e => e.MainTinhThanh)
                .IsUnicode(false);

            modelBuilder.Entity<Province>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<Province>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Province>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Province>()
                .HasMany(e => e.UsersProvinces)
                .WithRequired(e => e.Province)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.SysFuncRolesStatusPermissions)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.ContentsSubjects)
                .WithRequired(e => e.Subject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SYS_PARAMETERS>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SysFunction>()
                .HasMany(e => e.Actions)
                .WithRequired(e => e.SysFunction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SysFunction>()
                .HasMany(e => e.SysFuncRolesStatusPermissions)
                .WithRequired(e => e.SysFunction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SysHuongDan>()
                .Property(e => e.VIDEO)
                .IsUnicode(false);

            modelBuilder.Entity<SysHuongDan>()
                .Property(e => e.DPF)
                .IsUnicode(false);

            modelBuilder.Entity<SysHuongDan>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<TraoDoiNghiepVuCauHoi>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<TraoDoiNghiepVuCauHoi>()
                .Property(e => e.ImageBig)
                .IsUnicode(false);

            modelBuilder.Entity<TraoDoiNghiepVuCauHoiActionHistory>()
                .Property(e => e.Creator)
                .IsUnicode(false);

            modelBuilder.Entity<TraoDoiNghiepVuTraLoi>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<TraoDoiNghiepVuTraLoi>()
                .Property(e => e.ImageBig)
                .IsUnicode(false);

            modelBuilder.Entity<TraoDoiNghiepVuTraLoiActionHistory>()
                .Property(e => e.Creator)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatorId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Products1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.ModifierId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UsersMenus)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UsersProvinces)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UsersProvince>()
                .Property(e => e.Id)
                .IsFixedLength();

            modelBuilder.Entity<VBPQCheDinhPhapLuat>()
                .HasMany(e => e.VBPQCheDinhPhapLuatDocuments)
                .WithOptional(e => e.VBPQCheDinhPhapLuat)
                .HasForeignKey(e => e.CheDinhPhapLuatId);

            modelBuilder.Entity<VBPQChucDanh>()
                .HasMany(e => e.VBPQChucDanhNguoiKies)
                .WithOptional(e => e.VBPQChucDanh)
                .HasForeignKey(e => e.ChucDanhId);

            modelBuilder.Entity<VBPQCoQuanBH>()
                .HasMany(e => e.VBPQCoQuanBanHanhDocuments)
                .WithOptional(e => e.VBPQCoQuanBH)
                .HasForeignKey(e => e.CoQuanBanHanh);

            modelBuilder.Entity<VBPQDocument>()
                .HasOptional(e => e.VBPQCheDinhPhapLuatDocument)
                .WithRequired(e => e.VBPQDocument);

            modelBuilder.Entity<VBPQDocument>()
                .HasMany(e => e.VBPQChucDanhNguoiKies)
                .WithOptional(e => e.VBPQDocument)
                .HasForeignKey(e => e.DocumentId);

            modelBuilder.Entity<VBPQDocument>()
                .HasMany(e => e.VBPQCoQuanBanHanhDocuments)
                .WithOptional(e => e.VBPQDocument)
                .HasForeignKey(e => e.DocumentId);

            modelBuilder.Entity<VBPQDocument>()
                .HasMany(e => e.VBPQLinhVucPhapLuatDocuments)
                .WithOptional(e => e.VBPQDocument)
                .HasForeignKey(e => e.DocumentId);

            modelBuilder.Entity<VBPQDocument>()
                .HasMany(e => e.VBPQPhamViDieuChinhDocuments)
                .WithOptional(e => e.VBPQDocument)
                .HasForeignKey(e => e.DocumentId);

            modelBuilder.Entity<VBPQLinhVucPhapLuat>()
                .HasMany(e => e.VBPQLinhVucPhapLuatDocuments)
                .WithOptional(e => e.VBPQLinhVucPhapLuat)
                .HasForeignKey(e => e.LinhVucPhapLuatId);

            modelBuilder.Entity<VBPQLoaiVanBan>()
                .HasMany(e => e.VBPQDocuments)
                .WithOptional(e => e.VBPQLoaiVanBan)
                .HasForeignKey(e => e.LoaiVanBanId);

            modelBuilder.Entity<VBPQNguoiKy>()
                .HasMany(e => e.VBPQChucDanhNguoiKies)
                .WithOptional(e => e.VBPQNguoiKy)
                .HasForeignKey(e => e.NguoiKyId);

            modelBuilder.Entity<VBPQPhamViDieuChinh>()
                .HasMany(e => e.VBPQPhamViDieuChinhDocuments)
                .WithOptional(e => e.VBPQPhamViDieuChinh)
                .HasForeignKey(e => e.PhamViDieuChinhId);

            modelBuilder.Entity<Poll>()
                .Property(e => e.BlockMode)
                .IsUnicode(false);

            modelBuilder.Entity<Poll>()
                .Property(e => e.PollOption)
                .IsUnicode(false);
        }
    }
}
