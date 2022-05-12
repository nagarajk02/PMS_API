using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Profile65{
     public class ProfileStatus
    {
        [Key]
        public int ProfileStatusId{get; set;}
        public string  ProfileStatusName{get;set;}
        public bool IsActive { get; set; } = true;
        

        
    }
}