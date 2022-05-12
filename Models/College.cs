using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Profile65{
     public class College
    {
        [Key]
        public int CollegeId{get; set;}
        [Required]
        [StringLength(80)] 
        public string CollegeName{get;set;}
        [InverseProperty("college")]
        public virtual ICollection<Education>? education  {get;set;}
        public bool IsActive { get; set; } = true;
        

        
    }
}