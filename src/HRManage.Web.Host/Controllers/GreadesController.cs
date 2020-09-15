using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRManage.Ping;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRManage.Web.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreadesController : ControllerBase
    {
        private readonly IPingService pingService;
        const int MaxNum = 10;

    }
}
