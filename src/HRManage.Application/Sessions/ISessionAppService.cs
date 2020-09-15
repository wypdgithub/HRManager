using System.Threading.Tasks;
using Abp.Application.Services;
using HRManage.Sessions.Dto;

namespace HRManage.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
