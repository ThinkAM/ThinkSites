using System.ComponentModel.DataAnnotations;

namespace ThinkSites.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}