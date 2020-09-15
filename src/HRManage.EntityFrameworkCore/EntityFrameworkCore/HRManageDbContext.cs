using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HRManage.Authorization.Roles;
using HRManage.Authorization.Users;
using HRManage.MultiTenancy;
using HRManager.Entitys;
using HRManage.Models.Attendance_sheet;

namespace HRManage.EntityFrameworkCore
{
    public class HRManageDbContext : AbpZeroDbContext<Tenant, Role, User, HRManageDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HRManageDbContext(DbContextOptions<HRManageDbContext> options)
            : base(options)
        {

        }
        public DbSet<Detailed> Detailed { get; set; }                   //详细表
        public DbSet<Sign_In_Tb> Sign_In_Tb { get; set; }               //签到表
        public DbSet<Please_Leave>  Please_Leave { get; set; }          //请假申请表
        public DbSet<Please_Leave_Type>  Please_Leave_Type { get; set; }//请假类型表
        public DbSet<Evection> Evection { get; set; }//出差表

    }
}
