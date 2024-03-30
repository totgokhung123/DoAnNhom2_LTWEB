namespace DoAnNhom2_LTWEB.Models
{
    public class TINH
    {
        public int Id { get; set; }
        public string? TENTINH { get; set; }
        public string? TRANGTHAI { get; set; }
        public List<NHATUYENDUNG>? NHATUYENDUNGs { get; set; }
        public List<PHIEUDANGTUYEN>? PHIEUDANGTUYENs { get; set; }
    }
}
