using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DoAnNhom2_LTWEB.Models
{
    public class USERTK :IdentityUser
    {

        [StringLength(100, ErrorMessage = "họ tên không quá 100 ký tự")]
        public string? HOTEN { get; set; }
        [StringLength(13, ErrorMessage = "Số điện thoại không quá 13 ký tự")]
        public string? SDT { get; set; }
        [StringLength(13, ErrorMessage = "Căn cước công dân không quá 13 ký tự")]
        public string? CCCD { get; set; }
        //public string? Email { get; set; }
        public string? IMG { get; set; }
    }
}
