using System.ComponentModel.DataAnnotations;

namespace DoAnNhom2_LTWEB.Models
{
    public class LOAINGANH
    {
        public int Id {  get; set; }
        [StringLength(100, ErrorMessage = "Tên lĩnh vực không quá 100 ký tự")]
        public int TENLOAI { get; set; }
        public List<NGANHUNGTUYEN>? NGANHUNGTUYENs { get; set; }
    }
}
