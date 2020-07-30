using HNKWebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace HNKWebAPI.DataSource {
    public class DataSourceContext : DbContext {
        public DataSourceContext(DbContextOptions options) : base(options) {

        }
        public DbSet<Menus> Menus { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<RoleMenuMaps> RoleMenuMaps { get; set; }
        public DbSet<RolePermissionMaps> RolePermissionMaps { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<UserRoleMaps> UserRoleMaps { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
