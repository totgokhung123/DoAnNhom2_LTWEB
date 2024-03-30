using System.ComponentModel.DataAnnotations;

namespace DoAnNhom2_LTWEB.Models
{
    public class KINHNGHIEM
    {
        public int Id {  get; set; }
        [StringLength(30, ErrorMessage = "The title name cannot be more than 30 characters.")]
        public string NAMKN {  get; set; }
        public List<PHIEUDANGTUYEN>? PHIEUDANGTUYENs { get; set; }
    }
}
