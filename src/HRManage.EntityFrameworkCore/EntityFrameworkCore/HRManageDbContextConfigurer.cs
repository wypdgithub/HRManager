using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HRManage.EntityFrameworkCore
{
    public static class HRManageDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HRManageDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HRManageDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
