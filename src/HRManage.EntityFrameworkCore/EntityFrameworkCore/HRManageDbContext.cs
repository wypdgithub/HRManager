using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HRManage.Authorization.Users;
using HRManage.MultiTenancy;
using HRManage.Models.Attendance_sheet;
using HRManage.Models.AuthorityManagement;
using HRManage.Models.Grades;
using HRManage.Models.Grade;

namespace HRManage.EntityFrameworkCore
{
    public class HRManageDbContext : AbpZeroDbContext<Tenant, HRManage.Authorization.Roles.Role, User, HRManageDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public HRManageDbContext(DbContextOptions<HRManageDbContext> options)
            : base(options)
        {

        }
        public DbSet<Detailed> Detailed { get; set; }                   //详细表
        public DbSet<Sign_In_Tb> Sign_In_Tb { get; set; }               //签到表
        public DbSet<Please_Leave> Please_Leave { get; set; }          //请假申请表
        public DbSet<Please_Leave_Type> Please_Leave_Type { get; set; }//请假类型表
        public DbSet<Evection> Evection { get; set; }//出差表
        public DbSet<Extra_Work> Extra_Work { get; set; }//加班表
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Yearstaff> Yearstaffs { get; set; }
        public DbSet<Yearlead> Yearleads { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Monthstaff> Monthstaffs { get; set; }
        public DbSet<Monthlead> Monthleads { get; set; }
        public DbSet<Grade> Gradess { get; set; }
    }
}
