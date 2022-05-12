using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Profile65
{
    public class PersonalDetails
    {
        [Key]
        public int PersonalDetailsId{get;set;}
        public string Objective{get;set;}
        public DateTime DateOfBirth{get;set;}
        public string Nationality{get;set;}
        public DateTime DateOfJoining{get;set;}
        public DateTime? CreatedOn { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }
        public int languageid {get;set;}
        public int breakDurationid{get;set;}
        public int socialmediaid{get;set;}
        public int? UpdatedBy { get; set; }
        public int UserId { get; set; }
        

        [ForeignKey("languageid")]
        // [InverseProperty("personalDetails")]
        public virtual Language? language { get; set; }
        [ForeignKey("breakDurationid")]
        // [InverseProperty("personalDetails")]
        public virtual BreakDuration? breakDuration { get; set; }

        [ForeignKey("socialmediaid")]  
        // [InverseProperty("personalDetails")]
        public virtual SocialMedia? socialmedia { get; set; }
        [InverseProperty("personalDetails")]
        public virtual ICollection<Education>? education { get; set;}
        [InverseProperty("personalDetails")]
        public virtual ICollection<Projects>? projects { get; set;}
        [InverseProperty("personalDetails")]
        public virtual ICollection<Skills>? skills { get; set;}
        [ForeignKey("UserId")]
        [InverseProperty("personalDetails")]
        public virtual User? users { get; set; }
        public bool IsActive{ get; set;}
       

    }
}