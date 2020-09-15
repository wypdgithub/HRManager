using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HRManage.Authorization.Roles;
using HRManage.Authorization.Users;
using HRManage.MultiTenancy;
using HRManager.Entitys;

namespace HRManage.EntityFrameworkCore
{
    public class HRManageDbContext : AbpZeroDbContext<Tenant, Role, User, HRManageDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HRManageDbContext(DbContextOptions<HRManageDbContext> options)
            : base(options)
        {

        }
        public DbSet<Detailed> Detailed { get; set; }
        public DbSet<Sign_In_Tb> Sign_In_Tb { get; set; }
    }
}
