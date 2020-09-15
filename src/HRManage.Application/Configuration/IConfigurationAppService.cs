using System.Threading.Tasks;
using HRManage.Configuration.Dto;

namespace HRManage.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
