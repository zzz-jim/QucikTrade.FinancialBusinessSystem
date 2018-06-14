using System.ComponentModel.DataAnnotations;

namespace QucikTrade.FinancialBusinessSystem.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}