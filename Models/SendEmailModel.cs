using System.ComponentModel.DataAnnotations;

namespace BlazorSample.Models
{
    public class SendEmailModel
    {
        [Required]
        public string Subject { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "To Address")]
        public string ToAddress { get; set; }

        [Required]
        public string Body { get; set; }
    }
}
