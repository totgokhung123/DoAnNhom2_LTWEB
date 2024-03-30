using System.ComponentModel.DataAnnotations;

namespace DoAnNhom2_LTWEB.Models
{
    public class NGANHUNGTUYEN
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter title name")]
        [StringLength(100, ErrorMessage = "The title name cannot be more than 100 characters.")]
        public string? TENNGANH { get; set; }
        public int LOAINGANHId { get; set; }
        public LOAINGANH? LOAINGANH { get; set; }
        public List<PHIEUDANGTUYEN>? PHIEUDANGTUYENs { get; set; }
    }
}
