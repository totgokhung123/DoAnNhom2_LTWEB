using System.ComponentModel.DataAnnotations;

namespace DoAnNhom2_LTWEB.Models
{
    public class PHIEUDANGTUYEN
    {
        public int Id { get; set; }
        public int? NHATUYENDUNGId { get; set; }
        public NHATUYENDUNG? NHATUYENDUNG { get; set; }
        public int? NGANHUNGTUYENId { get; set; }
        public NGANHUNGTUYEN? NGANHUNGTUYEN { get; set; }
        public int? KINHNGHIEMId { get; set; }
        public KINHNGHIEM? KINHNGHIEM { get; set; }
        public int? TINHId { get; set; }
        public TINH? TINH { get; set; }        
        public string? TENVIECLAM { get; set; }
        public string? CHUCDANH { get; set; }
        public int? MUCLUONGId { get; set; }
        public MUCLUONG? MUCLUONG { get; set; }
        public string? MOTA { get; set; }
        [Required(ErrorMessage = "Please enter title adress")]
        [StringLength(300, ErrorMessage = "The title name cannot be more than 100 characters.")]
        public string DIADIEM { get; set; }
        public DateTime NGAYLAP { get; set; }
        public DateTime HANPHIEU { get; set; }
    }
}
