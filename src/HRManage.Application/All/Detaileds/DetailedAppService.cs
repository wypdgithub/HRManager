using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using HRManage.All.KQ.Dto;
using HRManage.Models.Attendance_sheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRManage.All.KQ
{
  public   class DetailedAppService:CrudAppService<Detailed, DetailedDto, Guid,PagedAndSortedResultRequestDto, CreateUptDetailedDto>,IDetailedAppService
    {
        public DetailedAppService(IRepository<Detailed,Guid> repository)
            : base(repository)
        {

        }

        protected override IQueryable<Detailed> CreateFilteredQuery(PagedAndSortedResultRequestDto input)
        {
            return base.CreateFilteredQuery(input);
        }

    }
}
