using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Profile65{
     public class Gender
    {
        [Key]
        public int GenderId{get; set;}
        public string  GenderName{get;set;}
        [InverseProperty("gender")]
        public virtual ICollection<User>?  users{get;set;}
        public bool IsActive { get; set; } = true;
        

        
    }
}