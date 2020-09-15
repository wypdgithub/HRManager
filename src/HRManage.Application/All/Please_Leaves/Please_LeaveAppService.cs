using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using HRManage.All.Please_Leaves.Dto;
using HRManage.Models.Attendance_sheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRManage.All.Please_Leaves
{
   public class Please_LeaveAppService:CrudAppService<Please_Leave, Please_LeaveDto, Guid, PagedAndSortedResultRequestDto, CreateUptPlease_LeaveDto>,IPlease_LeaveAppService
    {
        public Please_LeaveAppService(IRepository<Please_Leave,Guid> repository):base(repository)
        {

        }

        protected override IQueryable<Please_Leave> CreateFilteredQuery(PagedAndSortedResultRequestDto input)
        {
            return base.CreateFilteredQuery(input);
        }
    }
}
