using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Profile65{
     public class Technology
    {
        [Key]
        public int TechnologyId{get; set;}
        [Required]
        public string TechnologyName{get;set;}
        [InverseProperty("technology")]
        public virtual ICollection<Domain>?  domains{get;set;}
        public bool IsActive { get; set; } = true;
        

        
    }
}