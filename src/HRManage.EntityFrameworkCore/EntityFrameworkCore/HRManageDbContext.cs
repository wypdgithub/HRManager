using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HRManage.Authorization.Roles;
using HRManage.Authorization.Users;
using HRManage.MultiTenancy;

namespace HRManage.EntityFrameworkCore
{
    public class HRManageDbContext : AbpZeroDbContext<Tenant, Role, User, HRManageDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HRManageDbContext(DbContextOptions<HRManageDbContext> options)
            : base(options)
        {

        }
    }
}
