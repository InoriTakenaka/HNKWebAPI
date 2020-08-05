using HNKWebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace HNKWebAPI.DataSource {
    public class DataSourceContext : DbContext {
        public DataSourceContext(DbContextOptions options) : base(options) {

        }
        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<Department>().HasKey(p => p.DepartID);
            builder.Entity<RewardRecord>().HasKey(p => p.RecordID);
            builder.Entity<RewardRecord>().Property(p => p.AwardMoney)
                .HasColumnType("decimal(12,2)");
            builder.Entity<StaffInfo>().HasKey(p => p.StaffID);
            builder.Entity<TitleRecord>().HasKey(p => p.TitleID);
        }
        public DbSet<Menus> Menus { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<RoleMenuMaps> RoleMenuMaps { get; set; }
        public DbSet<RolePermissionMaps> RolePermissionMaps { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<UserRoleMaps> UserRoleMaps { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<StaffInfo> StaffInfos { get; set; }
        public DbSet<TitleRecord> TitleRecords { get; set; }
        public DbSet<RewardRecord> RewardRecords { get; set; }
    }
}
