using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DoAnNhom2_LTWEB.Models
{
    public class NHATUYENDUNG 
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter title name")]
        [StringLength(100, ErrorMessage = "The title name cannot be more than 100 characters.")]
        public string TENNTD { get; set; }
        [Required(ErrorMessage = "Please enter Phone")]
        [StringLength(13, ErrorMessage = "The title name cannot be more than 13 characters.")]
        public string? SDT { get; set; }
        public int TINHId { get; set; }
        public TINH? TINH { get; set; }
        [Required(ErrorMessage = "Please enter adress")]
        [StringLength(300, ErrorMessage = "The title name cannot be more than 300 characters.")]
        public string DIADIEM { get; set; }
        [Required(ErrorMessage = "Please enter email")]
        [StringLength(300, ErrorMessage = "The title name cannot be more than 300 characters.")]
        public string EMAIL { get; set; }
        public string? IMGDAIDIEN { get; set; }
        public string? IMGBANGTIN { get; set; }
        public string? TRANGTHAI { get; set; }
        public string? WEBSITE { get; set; }
        public string? QUYMO { get; set; }
        public string? MOTA { get; set; }
        public USERTK? USERTK { get; set; }
        [Display(Name = "Employer")]
        public Guid USERTKId { get; set; }
    }
}
