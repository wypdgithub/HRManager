using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using HRManage.Models.Grades;
using HRManage.Ping;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRManage.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreadesController : ControllerBase
    {
        private readonly IPingService pingService;
        const int MaxNum = 10;

        public CreadesController (IPingService  ping)
        {
            pingService = ping;
        }

        public PagedResultDto<YearleadDto> GetYearlead()
        {
            var list=pingService.GetAll((new PagedAndSortedResultRequestDto { MaxResultCount = MaxNum })).Items;
            return (PagedResultDto<YearleadDto>)list;
        }
    }
}
