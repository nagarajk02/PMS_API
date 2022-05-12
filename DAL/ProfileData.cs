using System.ComponentModel.DataAnnotations;

namespace Profile65
{
    // public interface IProfiledata
    // {
    //     PersonalDetail GetUser(int id);

    //     bool UpdatePersonalDetail(PersonalDetail item);
    // }

    // public class ProfileData : IProfiledata
    // {
    //     private ProfileContext _ProfileContext;
    //     private ILogger<ProfileService> _logger;
    //     public ProfileData(ProfileContext context, ILogger<ProfileService> logger)
    //     {
    //         _ProfileContext = context;
    //         _logger = logger;
    //     }

    //     public PersonalDetail GetUser(int id)
    //     {
    //         if (id <= 0)

    //             throw new ValidationException("User Id is not provided to DataAccessLayer");

    //         try
    //         {
    //             PersonalDetail user = _ProfileContext.personalDetails.Find(id);
    //             if (user == null) throw new NullReferenceException($"Id not found-{id}");
    //             return user;
    //         }
    //         catch (Exception exception)
    //         {
    //             _logger.LogError($"UserData.cs-GetUser()-{exception.Message}");
    //             _logger.LogInformation($"UserData.cs-GetUser()-{exception.StackTrace}");
    //             throw;
    //         }
    //     }

    //     public bool UpdatePersonalDetail(PersonalDetail item)
    //     {
    //         if (item == null)
    //             throw new ValidationException("User values is not provided to DAL");


    //         try
    //         {
    //             var Profile = _ProfileContext.personalDetails.Find(item.PersonalDetailsId);//  personadetails = _ProfileContext.personalDetails.GetUser(id)
    //             if (Profile == null) throw new NullReferenceException($"Profile Id not found{item.PersonalDetailsId}");
    //             Profile.PersonalDetailsId = item.PersonalDetailsId;
    //             Profile.Objective = item.Objective;
    //             Profile.DateOfBirth = item.DateOfBirth;
    //             Profile.Experience = item.Experience;
    //             Profile.DateOfJoin = item.DateOfJoin;
    //             Profile.Nationality = item.Nationality;
    //             //Profile.IsActive = item.IsActive;
    //             Profile.CreatedBy = item.CreatedBy;
    //             _ProfileContext.Update(Profile);
    //             _ProfileContext.SaveChanges();
    //             return true;
    //         }
    //         catch (Exception exception)
    //         {
    //             //log " exception occures"
    //             _logger.LogError($"ProfileData.cs-UpdatePersonalDetail)-{exception.Message}");
    //             _logger.LogInformation($"ProfileData.cs-UpdatePersonalDetail()-{exception.StackTrace}");
    //             return false;
    //         }
    //         throw new NotImplementedException();
    //     }

    //     public bool UpdateSkill(Skill item)
    //     {
    //         throw new NotImplementedException();
    //     }


    

    public interface IPersonalDetails
    {

    }
    public class ProfileData
    {
        private Context _context;
        private ILogger<PersonalService> _logger;

        public ProfileData(Context context, ILogger<PersonalService> logger)
        {
            _context = context;
            _logger = logger;
        }
        public List<PersonalDetails> GetallPersonalDetails()
        {

            try
            {

                return _context.personalDetails.ToList();

            }

            catch (Exception exception)
            {
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-GetallPersonalDetails()-{exception.Message}");
                _logger.LogInformation($"UserData.cs-GetallPersonalDetails()-{exception.StackTrace}");
                throw exception;
            }
        }

        // public bool AddPersonalDetail(PersonalDetails personalDetails)
        // {


        //     if (personalDetails == null)
        //         throw new ArgumentNullException("personalDetails object is not provided to DAL");

        //     try
        //     {

        //         _context.personalDetails.Add(personalDetails);
        //         _context.SaveChanges();
        //         return true;
        //     }

        //     catch (Exception exception)
        //     {
        //         //log "unknown exception occured"
        //         _logger.LogError($"ProfileData.cs-AddPersonalDetails()-{exception.Message}");
        //         _logger.LogInformation($"ProfileData.cs-AddPersonalDetails()-{exception.StackTrace}");

        //         return false;
        //     }


        // }
        public bool UpdatePersonalDetail(PersonalDetails personalDetails)
        {
            if (personalDetails == null)
                throw new ValidationException("profile's personal details is not provided to DAL");


            try
            {
                var Profile = _context.personalDetails.Find(personalDetails.PersonalDetailsId);//  personadetails = _ProfileContext.personalDetails.GetUser(id)
                if (Profile == null) throw new NullReferenceException($"Profile Id not found{personalDetails.PersonalDetailsId}");
                // Profile.PersonalDetailsId = personalDetails.PersonalDetailsId;
                // Profile.Objective = personalDetails.Objective;
                // Profile.DateOfBirth = personalDetails.DateOfBirth;
                // // Profile.Experience = personalDetails.Experience;
                // // Profile.DateOfJoin = personalDetails.DateOfJoin;
                // Profile.Nationality = personalDetails.Nationality;
                // Profile.IsActive = personalDetails.IsActive;
                // Profile.UpdatedBy = personalDetails.UpdatedBy;
                _context.Update(personalDetails);
                _context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                //log " exception occures"
                _logger.LogError($"ProfileData.cs-UpdatePersonalDetail)-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-UpdatePersonalDetail()-{exception.StackTrace}");
                return false;
            }

        }
        // public bool RemovePersonalDetail(int PersonalDetailsId)
        // {
        //     if (PersonalDetailsId <= 0)
        //         throw new ValidationException("PersonalDetails Id is not provided to DAL");

        //     try
        //     {
        //         var personalDetails = _context.personalDetails.Find(PersonalDetailsId);

        //         //do null validation for personaldetails
        //         if (personalDetails == null) throw new NullReferenceException($"PersonalDetails Id not found{PersonalDetailsId}");
        //         personalDetails.IsActive = false;
        //         _context.personalDetails.Update(personalDetails);
        //         _context.SaveChanges();
        //         return true;

        //     }


        //     catch (Exception exception)
        //     {
        //         //log "if exception occures"
        //         _logger.LogError($"ProfileData.cs-Disable()-{exception.Message}");
        //         _logger.LogInformation($"ProfileData.cs-Disable()-{exception.StackTrace}");
        //         return false;
        //     }

        // }
        // public bool AddEducation(Education education)
        // {


        //     if (education == null)
        //         throw new ArgumentNullException("Education detail object is not provided to DAL");

        //     try
        //     {

        //         _context.educations.Add(education);
        //         _context.SaveChanges();
        //         return true;
        //     }

        //     catch (Exception exception)
        //     {
        //         //log "unknown exception occured"
        //         _logger.LogError($"ProfileData.cs-AddEducation()-{exception.Message}");
        //         _logger.LogInformation($"ProfileData.cs-AddEducation()-{exception.StackTrace}");

        //         return false;
        //     }


        // }
        public bool UpdateEducation(Education education)
        {
            if (education == null)
                throw new ValidationException("User values is not provided to DAL");


            try
            {
                var Profile = _context.educations.Find(education.EducationId);//  personadetails = _ProfileContext.personalDetails.GetUser(id)
    
                if (Profile == null) throw new NullReferenceException($"Profile Id not found{education.EducationId}");
                // Profile.personaldetailsId = education.personaldetailsId;
                // Profile.Degree = education.Degree;
                // Profile.Course = education.Course;
                // Profile.Starting_Year = education.Starting_Year;
                // Profile.Ending_Year = education.Ending_Year;
                // Profile.Percentage = education.Percentage;
                // Profile.IsActive = education.IsActive;
                // Profile.UpdatedBy = education.UpdatedBy;
                _context.Update(education);
                _context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                //log " exception occures"
                _logger.LogError($"ProfileData.cs-UpdatePersonalDetail)-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-UpdatePersonalDetail()-{exception.StackTrace}");
                return false;
            }

        }
        // public bool RemoveEducation(int Education_Id)
        // {
        //     if (Education_Id <= 0)

        //         throw new ValidationException("Education Id is not provided to DAL");

        //     try
        //     {
        //         var educations = _context.educations.Find(Education_Id);

        //         //do null validation for education
        //         if (educations == null) throw new NullReferenceException($"Education Id not found{Education_Id}");
        //         educations.IsActive = false;
        //         _context.educations.Update(educations);
        //         _context.SaveChanges();
        //         return true;

        //     }


        //     catch (Exception exception)
        //     {
        //         //log "if exception occures"
        //         _logger.LogError($"ProfileData.cs-Disable()-{exception.Message}");
        //         _logger.LogInformation($"ProfileDate.cs-Disable()-{exception.StackTrace}");
        //         return false;
        //     }

        // }
        // public bool AddProjects(Projects projects)
        // {


        //     if (projects == null)
        //         throw new ArgumentNullException("project detail object is not provided to DAL");

        //     try
        //     {

        //         _context.projects.Add(projects);
        //         _context.SaveChanges();
        //         return true;
        //     }

        //     catch (Exception exception)
        //     {
        //         //log "unknown exception occured"
        //         _logger.LogError($"ProfileData.cs-AddProjects()-{exception.Message}");
        //         _logger.LogInformation($"ProfileData.cs-AddProjects()-{exception.StackTrace}");

        //         return false;
        //     }


        // }
        public bool UpdateProjects(Projects projects)
        {
            if (projects == null)
                throw new ValidationException("User values is not provided to DAL");


            try
            {
                var Profile = _context.projects.Find(projects.ProjectId);//  personadetails = _ProfileContext.personalDetails.GetUser(id)
                if (Profile == null) throw new NullReferenceException($"Profile Id not found{projects.PersonalDetailsId}");
                // Profile.PersonalDetailsId = projects.PersonalDetailsId;
                // Profile.Project_Id = projects.Project_Id;
                // Profile.ProjectName = projects.ProjectName;
                // Profile.project_Description = projects.project_Description;
                // Profile.Project_Starting_Month = projects.Project_Starting_Month;
                // Profile.Project_Starting_Year = projects.Project_Starting_Year;
                // Profile.Project_Ending_Month = projects.Project_Ending_Month;
                // Profile.Project_Ending_Year = projects.Project_Ending_Year;
                // Profile.IsActive = projects.IsActive;
                // Profile.UpdatedBy = projects.UpdatedBy;
                _context.Update(projects);
                _context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                //log " exception occures"
                _logger.LogError($"ProfileData.cs-UpdatePersonalDetail)-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-UpdatePersonalDetail()-{exception.StackTrace}");
                return false;
            }
            throw new NotImplementedException();
        }
        // public bool RemoveProjects(int Project_Id)
        // {
        //     if (Project_Id <= 0)

        //         throw new ValidationException("Project Id is not provided to DAL");

        //     try
        //     {
        //         var projects = _context.projects.Find(Project_Id);

        //         //do null validation for 
        //         if (projects == null)
        //             throw new NullReferenceException($"Project Id not found{Project_Id}");

        //         projects.IsActive = false;
        //         _context.projects.Update(projects);
        //         _context.SaveChanges();
        //         return true;

        //     }


        //     catch (Exception exception)
        //     {
        //         //log "if exception occures"
        //         _logger.LogError($"ProfileData.cs-Disable()-{exception.Message}");
        //         _logger.LogInformation($"ProfileData.cs-Disable()-{exception.StackTrace}");
        //         return false;
        //     }

        // }

        // public bool AddBreakDuration(BreakDuration duration)
        // {


        //     if (duration == null)
        //         throw new ArgumentNullException("Break duration detail object is not provided to DAL");

        //     try
        //     {

        //         _context.breakDurations.Add(duration);
        //         _context.SaveChanges();
        //         return true;
        //     }

        //     catch (Exception exception)
        //     {
        //         //log "unknown exception occured"
        //         _logger.LogError($"ProfileData.cs-AddBreakDuration()-{exception.Message}");
        //         _logger.LogInformation($"ProfileData.cs-AddSBreakDuration()-{exception.StackTrace}");

        //         return false;
        //     }


        // }
        internal bool UpdateBreakDuration(BreakDuration duration)
        {
            if (duration == null)
                throw new ValidationException("User values is not provided to DAL");


            try
            {
                var Profile = _context.breakDurations.Find(duration.BreakDuration_Id);//  personadetails = _ProfileContext.personalDetails.GetUser(id)
                if (Profile == null) throw new NullReferenceException($"Profile Id not found{duration.BreakDuration_Id}");
                // Profile.BreakDuration_Id = duration.BreakDuration_Id;
                // Profile.Starting_Month = duration.Starting_Month;
                // Profile.Starting_Year = duration.Starting_Year;
                // Profile.Ending_Month = duration.Ending_Month;
                // Profile.Ending_Year = duration.Ending_Year;
                // Profile.IsActive = duration.IsActive;
                // Profile.UpdatedBy = duration.UpdatedBy;
                _context.Update(duration);
                _context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                //log " exception occures"
                _logger.LogError($"ProfileData.cs-UpdatePersonalDetail)-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-UpdatePersonalDetail()-{exception.StackTrace}");
                return false;
            }
            throw new NotImplementedException();
        }
        // public bool RemoveBreakDuration(int BreakDuration_Id)
        // {
        //     if (BreakDuration_Id <= 0)

        //         throw new ValidationException("BreakDuration Id is not provided to DAL");

        //     try
        //     {
        //         var breakDurations = _context.breakDurations.Find(BreakDuration_Id);

        //         //do null validation for user
        //         if (breakDurations == null) throw new NullReferenceException($"Project Id not found{BreakDuration_Id}");
        //         breakDurations.IsActive = false;
        //         _context.breakDurations.Update(breakDurations);
        //         _context.SaveChanges();
        //         return true;

        //     }


        //     catch (Exception exception)
        //     {
        //         //log "if exception occures"
        //         _logger.LogError($"ProfileData.cs-Disable()-{exception.Message}");
        //         _logger.LogInformation($"ProfileData.cs-Disable()-{exception.StackTrace}");
        //         return false;
        //     }

        // }
        // public bool AddSkills(Skills skill)
        // {


        //     if (skill == null)
        //         throw new ArgumentNullException("Education detail object is not provided to DAL");

        //     try
        //     {

        //         _context.skills.Add(skill);
        //         _context.SaveChanges();
        //         return true;
        //     }

        //     catch (Exception exception)
        //     {
        //         //log "unknown exception occured"
        //         _logger.LogError($"ProfileData.cs-AddSkills()-{exception.Message}");
        //         _logger.LogInformation($"ProfileData.cs-AddSkills()-{exception.StackTrace}");

        //         return false;
        //     }


        // }
        public bool UpdateSkills(Skills skill)
        {
            if (skill == null)
                throw new ValidationException("User values is not provided to DAL");


            try
            {
                var Profile = _context.skills.Find(skill.PersonalDetailsId);//  personadetails = _ProfileContext.personalDetails.GetUser(id)
                if (Profile == null) throw new NullReferenceException($"Profile Id not found{skill.PersonalDetailsId}");
                // Profile.Skill_Id = skill.Skill_Id;
                // Profile.Domain = skill.Domain;
                // Profile.Technology = skill.Technology;
                // Profile.PersonalDetailsId = skill.PersonalDetailsId;
                // Profile.IsActive = skill.IsActive;
                // Profile.UpdatedBy = skill.UpdatedBy;
                _context.Update(skill);
                _context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                //log " exception occures"
                _logger.LogError($"ProfileData.cs-UpdatePersonalDetail)-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-UpdatePersonalDetail()-{exception.StackTrace}");
                return false;
            }
            throw new NotImplementedException();
        }
        // public bool RemoveSkills(int Skill_Id)
        // {
        //     if (Skill_Id <= 0)

        //         throw new ValidationException("Skill Id is not provided to DAL");

        //     try
        //     {
        //         var skills = _context.skills.Find(Skill_Id);

        //         //do null validation for user
        //         if (skills == null) throw new NullReferenceException($"Skill Id not found{Skill_Id}");
        //         skills.IsActive = false;
        //         _context.skills.Update(skills);
        //         _context.SaveChanges();
        //         return true;

        //     }


        //     catch (Exception exception)
        //     {
        //         //log "if exception occures"
        //         _logger.LogError($"ProfileData.cs-Disable()-{exception.Message}");
        //         _logger.LogInformation($"ProfileData.cs-Disable()-{exception.StackTrace}");
        //         return false;
        //     }

        // }
        // public bool AddLanguage(Language language)
        // {


        //     if (language == null)
        //         throw new ArgumentNullException("Language details object is not provided to DAL");

        //     try
        //     {

        //         _context.languages.Add(language);
        //         _context.SaveChanges();
        //         return true;
        //     }

        //     catch (Exception exception)
        //     {
        //         //log "unknown exception occured"
        //         _logger.LogError($"ProfileData.cs-AddLanguage()-{exception.Message}");
        //         _logger.LogInformation($"ProfileData.cs-AddLanguage()-{exception.StackTrace}");

        //         return false;
        //     }


        // }
        public bool UpdateLanguage(Language language)
        {
            if (language == null)
                throw new ValidationException("User values is not provided to DAL");


            try
            {
                var Profile = _context.languages.Find(language.LanguageId);//  personadetails = _ProfileContext.personalDetails.GetUser(id)
                if (Profile == null) throw new NullReferenceException($"Profile Id not found{language.LanguageId}");
                
                _context.Update(language);
                _context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                //log " exception occures"
                _logger.LogError($"ProfileData.cs-UpdatePersonalDetail)-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-UpdatePersonalDetail()-{exception.StackTrace}");
                return false;
            }
            throw new NotImplementedException();
        }
        // public bool RemoveLanguage(int Language_Id)
        // {
        //     if (Language_Id <= 0)

        //         throw new ValidationException("Language Id is not provided to DAL");

        //     try
        //     {
        //         var languages = _context.languages.Find(Language_Id);

        //         //do null validation for user
        //         if (languages == null) throw new NullReferenceException($"Language Id not found{Language_Id}");
        //         languages.IsActive = false;
        //         _context.languages.Update(languages);
        //         _context.SaveChanges();
        //         return true;

        //     }


        //     catch (Exception exception)
        //     {
        //         //log "if exception occures"
        //         _logger.LogError($"ProfileData.cs-Disable()-{exception.Message}");
        //         _logger.LogInformation($"ProfileData.cs-Disable()-{exception.StackTrace}");
        //         return false;
        //     }

        // }
        // public bool AddSocialMedia(SocialMedia media)
        // {
        //     if (media == null)
        //         throw new ArgumentNullException("social media details object is not provided to DAL");
        //     try
        //     {

        //         _context.socialMedias.Add(media);
        //         _context.SaveChanges();
        //         return true;
        //     }

        //     catch (Exception exception)
        //     {
        //         //log "unknown exception occured"
        //         _logger.LogError($"ProfileData.cs-AddSocialMedia()-{exception.Message}");
        //         _logger.LogInformation($"ProfileData.cs-AddSocialMedia()-{exception.StackTrace}");

        //         return false;
        //     }
        // }
        public bool UpdateSocialMedia(SocialMedia media)
        {
            if (media == null)
                throw new ValidationException("User values is not provided to DAL");


            try
            {
                var Profile = _context.socialMedias.Find(media.SocialMedia_Id);//  personadetails = _ProfileContext.personalDetails.GetUser(id)
                if (Profile == null) throw new NullReferenceException($"Profile Id not found{media.SocialMedia_Id}");
                // Profile.SocialMedia_Id = media.SocialMedia_Id;
                // Profile.SocialMedia_Name = media.SocialMedia_Name;
                // Profile.SocialMedia_Link = media.SocialMedia_Link;
                
                // Profile.IsActive = media.IsActive;
                // Profile.UpdatedBy = media.UpdatedBy;
                _context.Update(media);
                _context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                //log " exception occures"
                _logger.LogError($"ProfileData.cs-UpdatePersonalDetail)-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-UpdatePersonalDetail()-{exception.StackTrace}");
                return false;
            }
            
        }
        // public bool RemoveSocialMedia(int SocialMedia_Id)
        // {
        //     if (SocialMedia_Id <= 0)

        //         throw new ValidationException("SocialMedia Id is not provided to DAL");

        //     try
        //     {
        //         var SocialMedias = _context.SocialMedias.Find(SocialMedia_Id);

        //         //do null validation for user
        //         if (SocialMedias == null) throw new NullReferenceException($"SocialMedia Id not found{SocialMedia_Id}");
        //         SocialMedias.IsActive = false;
        //         _context.SocialMedias.Update(SocialMedias);
        //         _context.SaveChanges();
        //         return true;

        //     }


        //     catch (Exception exception)
        //     {
        //         //log "if exception occures"
        //         _logger.LogError($"ProfileData.cs-Disable()-{exception.Message}");
        //         _logger.LogInformation($"ProfileData.cs-Disable()-{exception.StackTrace}");
        //         return false;
        //     }

        // }

    }
}