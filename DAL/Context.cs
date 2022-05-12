using Microsoft.EntityFrameworkCore;

namespace Profile65
{
    public class Context:DbContext{
        public Context()
        {
            
        }
        public Context(DbContextOptions<Context> options):base(options){

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
        optionsBuilder.UseSqlServer("server=Aspireren23;database=PMS;trusted_connection=true;");
}
        public DbSet<BreakDuration> breakDurations {get;set;}
        public DbSet<College> colleges {get;set;}
        public DbSet<Designation> designations {get;set;}
        public DbSet<Domain> domains {get;set;}
        
        
    

        public DbSet<Education>  educations{get;set;}
        public DbSet<Gender> genders{get;set;}
        // public DbSet<HR>  HRs {get;set;}
        public DbSet<Language> languages {get;set;}
        public DbSet<Organisation> organisations {get;set;}
        public DbSet<PersonalDetails> personalDetails {get;set;}
        public DbSet<ProfileStatus> profileStatuses {get;set;}
        // public DbSet<Role>  Roles {get;set;}
        public DbSet<Projects> projects{get;set;}
        public DbSet<Skills> skills {get;set;}
        public DbSet<SocialMedia> socialMedias {get;set;}
        public DbSet<Technology> Technologies {get;set;}
        public DbSet<User> users { get; set; }




    }
}