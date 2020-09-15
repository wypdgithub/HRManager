using System.ComponentModel.DataAnnotations;

namespace HRManage.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}