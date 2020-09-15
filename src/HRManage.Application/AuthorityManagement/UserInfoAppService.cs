using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using HRManage.AuthorityManagement.Dto;
using HRManage.Models.AuthorityManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.AuthorityManagement
{
    public class UserInfoAppService : CrudAppService<
        UserInfo,
        UserInfoDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateUserInfoDto>, IUserInfoAppService
    {
        public UserInfoAppService(IRepository<UserInfo, Guid> repository) : base(repository) { }
        public override UserInfoDto Create(CreateUpdateUserInfoDto input)
        {
            return base.Create(input);
        }
        public override UserInfoDto Get(EntityDto<Guid> input)
        {
            return base.Get(input); 
        }
        public override PagedResultDto<UserInfoDto> GetAll(PagedAndSortedResultRequestDto input)
        {
            return base.GetAll(input);  
        }
        public override void Delete(EntityDto<Guid> input)
        {
            base.Delete(input); 
        }
        public override UserInfoDto Update(CreateUpdateUserInfoDto input)
        {
            return base.Update(input);
        }
    }
}
