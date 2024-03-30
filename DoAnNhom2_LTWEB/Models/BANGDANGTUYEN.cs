namespace DoAnNhom2_LTWEB.Models
{
    public class BANGDANGTUYEN
    {
        public int Id { get; set; }
        public int PHIEUDANGTUYENId { get; set; }
        public PHIEUDANGTUYEN? PHIEUDANGTUYEN { get; set; }
    }
}
