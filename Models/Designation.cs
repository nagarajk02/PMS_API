using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Profile65{
     public class Designation
    {
        [Key]
        public int DesignationId{get; set;}
        [Required]
        [StringLength(80)]
        public string ? DesignationName{get;set;}
        [InverseProperty("designation")]
        public virtual ICollection<User>?  users  {get;set;}
        public bool IsActive { get; set; } = true;
        

        
    }
}