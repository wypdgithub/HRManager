using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using HRManage.Configuration;
using HRManage.Web;

namespace HRManage.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class HRManageDbContextFactory : IDesignTimeDbContextFactory<HRManageDbContext>
    {
        public HRManageDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HRManageDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            HRManageDbContextConfigurer.Configure(builder, configuration.GetConnectionString(HRManageConsts.ConnectionStringName));

            return new HRManageDbContext(builder.Options);
        }
    }
}
