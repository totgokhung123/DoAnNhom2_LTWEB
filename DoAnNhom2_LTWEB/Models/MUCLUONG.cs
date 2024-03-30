using System.ComponentModel.DataAnnotations;

namespace DoAnNhom2_LTWEB.Models
{
    public class MUCLUONG
    {
        public int Id {  get; set; }
        [StringLength(30, ErrorMessage = "The title name cannot be more than 30 characters.")]
        public string SOLUONG {  get; set; }
        public List<PHIEUDANGTUYEN>? PHIEUDANGTUYENs { get; set; }
    }
}
