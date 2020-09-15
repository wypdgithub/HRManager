using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRManage.AuthorityManagement.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.AuthorityManagement
{
  public  interface IUserInfoAppService:ICrudAppService<
      UserInfoDto,
      Guid,
      PagedAndSortedResultRequestDto,
      CreateUpdateUserInfoDto
      >
    {
    }
}
