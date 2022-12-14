using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Personal_Page.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(3,ErrorMessage = "حداقل طول نام 3 کاراکتر است")]
        [MaxLength(100,ErrorMessage = "حداکثر طول نام 100 کاراکتر است")]
        public string  Name { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress(ErrorMessage = "ایمیل را به درستی وارد  نکرده  اید")]
        public string Email { get; set; }
        public int Service { get; set; }
        public string Message { get; set; }
        public SelectList Services { get; set; }
         
    }
}
