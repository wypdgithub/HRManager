﻿using Abp.Application.Services.Dto;
using System;
using System.ComponentModel.DataAnnotations;

namespace HRManage.AuthorityManagement.Dto
{
    public class DepartmentDto:EntityDto<Guid>
    {
        [StringLength(20)]
        public string Name { get; set; }
    }
}
