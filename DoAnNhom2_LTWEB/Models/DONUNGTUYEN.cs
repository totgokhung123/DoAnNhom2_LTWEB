using System.ComponentModel.DataAnnotations;

namespace DoAnNhom2_LTWEB.Models
{
    public class DONUNGTUYEN
    {
        public int Id { get; set; }
        public USERTK? USERTK { get; set; }
        [Display(Name = "Employer")]
        public Guid USERTKId { get; set; }
        public string FILECV {  get; set; }
    }
}
