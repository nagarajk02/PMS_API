namespace Profile65
{
    public interface IPersonalService
    {
        // bool AddEducation(Education education);
        bool UpdateEducation(Education education);
        // bool RemoveEducation(int Education_Id);
        // bool AddPersonalDetail(PersonalDetails personalDetails);
        bool UpdatePersonalDetail(PersonalDetails personalDetails);
        // bool RemovePersonalDetail(int PersonalDetailsId);
        // bool AddProjects(Projects project);
        bool UpdateProjects(Projects projects);
        // bool RemoveProjects(int Project_Id);
        // bool AddSkills(Skills skill);
        bool UpdateSkills(Skills skill);
        // bool RemoveSkills(int Skill_Id);
        // bool AddBreakDuration(BreakDuration duration);
        bool UpdateBreakDuration(BreakDuration duration);
        // bool RemoveBreakDuration(int BreakDuration_Id);
        // bool AddLanguage(Language language);
        bool UpdateLanguage(Language language);
        // bool RemoveLanguage(int Language_Id);
        // bool AddSocialMedia(SocialMedia media);
        bool UpdateSocialMedia(SocialMedia media);
        // bool RemoveSocialMedia(int SocialMedia_Id);
        // IEnumerable<PersonalDetails> GetallPersonalDetails();

    }

    public class PersonalService : IPersonalService
    {

        ProfileData profileData;
        private ILogger<PersonalService> _logger;

        public PersonalService(ILogger<PersonalService> logger)
        {
            _logger = logger;
            profileData = DataFactory.GetProfileData(logger);

        }
        // public IEnumerable<PersonalDetails> GetallPersonalDetails()
        // {
        //     try
        //     {
        //         // IEnumerable<User> userDetails = new List<User>();

        //         return from personalDetails in profileData.GetallPersonalDetails() where personalDetails.IsActive == true select personalDetails;



        //     }
        //     catch (Exception exception)
        //     {
        //         // Log Exception occured in DAL while fetching users
        //         _logger.LogError($"PersonalServices:GetallPersonalDetails()-{exception.Message}\n{exception.StackTrace}");
        //         throw exception;
        //     }
        // }
        // public bool AddPersonalDetail(PersonalDetails personalDetails)
        // {
        //     if (personalDetails == null) throw new ArgumentNullException($"Values cannot be null values are {personalDetails}");
        //     try
        //     {
        //         personalDetails.CreatedBy = personalDetails.Name;
        //         personalDetails.CreatedOn = DateTime.Now;
        //         return profileData.AddPersonalDetail(personalDetails) ? true : false;
        //     }
        //     catch (Exception exception)
        //     {
        //         _logger.LogInformation($"PersonalServices:AddPersonalDetail()-{exception.Message}\n{exception.StackTrace}");
        //         return false;
        //     }

        // }
        public bool UpdatePersonalDetail(PersonalDetails personalDetails)
        {
            if (personalDetails == null) throw new ArgumentNullException($" ProfileService:Update()-user values not be null{personalDetails}");

            try
            {
                personalDetails.UpdatedBy = personalDetails.CreatedBy;
                personalDetails.UpdatedOn = DateTime.Now;
                return profileData.UpdatePersonalDetail(personalDetails);
            }
            catch( Exception exception) 
            {
                _logger.LogInformation($"ProfileService:Update()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
            
        }
        // public bool RemovePersonalDetail(int PersonalDetailsId)
        // {
        //     if (PersonalDetailsId <= 0)
        //         throw new ArgumentNullException($"PersonalDetails ID is not provided{PersonalDetailsId}");


        //     try
        //     {

        //         return profileData.RemovePersonalDetail(PersonalDetailsId) ? true : false;

        //     }

        //     catch (Exception exception)
        //     {
        //         _logger.LogInformation($"PersonalServices:Delete()-{exception.Message}\n{exception.StackTrace}");
        //         return false;
        //     }
        // }
        // public bool AddEducation(Education education)
        // {
        //     if (education == null) throw new ArgumentNullException($"Values cannot be null values are {education}");
        //     try
        //     {

        //         education.CreatedOn = DateTime.Now;
        //         return profileData.AddEducation(education) ? true : false;
        //     }
        //     catch (Exception exception)
        //     {
        //         _logger.LogInformation($"PersonalServices:AddEducation()-{exception.Message}\n{exception.StackTrace}");
        //         return false;
        //     }


        // }
        public bool UpdateEducation(Education education)
        {
            if (education == null) throw new ArgumentNullException($" ProfileService:Update()-user values not be null{education}");

            try
            {
                education.UpdatedBy = education.CreatedBy;
                education.UpdatedOn = DateTime.Now;
                return profileData.UpdateEducation(education);

            }

            catch (Exception exception)
            {
                _logger.LogInformation($"ProfileService:Update()-{exception.Message}\n{exception.StackTrace}");
                return false;

            }
        }
        // public bool RemoveEducation(int Education_Id)
        // {
        //     if (Education_Id <= 0)
        //         throw new ArgumentNullException($"Education ID is not provided{Education_Id}");


        //     try
        //     {

        //         return profileData.RemoveEducation(Education_Id) ? true : false;

        //     }

        //     catch (Exception exception)
        //     {
        //         _logger.LogInformation($"PersonalServices:Delete()-{exception.Message}\n{exception.StackTrace}");
        //         return false;
        //     }
        // }

        // public bool AddProjects(Projects project)
        // {
        //     if (project == null) throw new ArgumentNullException($"Values cannot be null values are {project}");
        //     try
        //     {

        //         project.CreatedOn = DateTime.Now;
        //         return profileData.AddProjects(project) ? true : false;
        //     }
        //     catch (Exception exception)
        //     {
        //         _logger.LogInformation($"PersonalServices:AddProjects()-{exception.Message}\n{exception.StackTrace}");
        //         return false;
        //     }


        // }
        public bool UpdateProjects(Projects projects)
        {
            if (projects == null) throw new ArgumentNullException($" ProfileService:Update()-user values not be null{projects}");

            try
            {
                projects.UpdatedBy = projects.CreatedBy;
                projects.UpdatedOn = DateTime.Now;
                return profileData.UpdateProjects(projects);

            }

            catch (Exception exception)
            {
                _logger.LogInformation($"ProfileService:Update()-{exception.Message}\n{exception.StackTrace}");
                return false;

            }
        }
        // public bool RemoveProjects(int Project_Id)
        // {
        //     if (Project_Id <= 0)
        //         throw new ArgumentNullException($"Project ID is not provided{Project_Id}");


        //     try
        //     {

        //         return profileData.RemoveProjects(Project_Id) ? true : false;

        //     }

        //     catch (Exception exception)
        //     {
        //         _logger.LogInformation($"PersonalServices:Delete()-{exception.Message}\n{exception.StackTrace}");
        //         return false;
        //     }
        // }

        // public bool AddSkills(Skills skill)
        // {
        //     if (skill == null) throw new ArgumentNullException($"Values cannot be null values are {skill}");
        //     try
        //     {

        //         skill.CreatedOn = DateTime.Now;
        //         return profileData.AddSkills(skill) ? true : false;
        //     }
        //     catch (Exception exception)
        //     {
        //         _logger.LogInformation($"PersonalServices:AddSkills()-{exception.Message}\n{exception.StackTrace}");
        //         return false;
        //     }


        // }
        public bool UpdateSkills(Skills skill)
        {
            if (skill == null) throw new ArgumentNullException($" ProfileService:Update()-user values not be null{skill}");

            try
            {
                skill.UpdatedBy = skill.CreatedBy;
                skill.UpdatedOn = DateTime.Now;
                return profileData.UpdateSkills(skill);

            }

            catch (Exception exception)
            {
                _logger.LogInformation($"ProfileService:Update()-{exception.Message}\n{exception.StackTrace}");
                return false;

            }
        }
        // public bool RemoveSkills(int Skill_Id)
        // {
        //     if (Skill_Id <= 0)
        //         throw new ArgumentNullException($"Skill ID is not provided{Skill_Id}");


        //     try
        //     {

        //         return profileData.RemoveSkills(Skill_Id) ? true : false;

        //     }

        //     catch (Exception exception)
        //     {
        //         _logger.LogInformation($"PersonalServices:Delete()-{exception.Message}\n{exception.StackTrace}");
        //         return false;
        //     }
        // }
        // public bool AddBreakDuration(BreakDuration duration)
        // {
        //     if (duration == null) throw new ArgumentNullException($"Values cannot be null values are {duration}");
        //     try
        //     {

        //         duration.CreatedOn = DateTime.Now;
        //         return profileData.AddBreakDuration(duration) ? true : false;
        //     }
        //     catch (Exception exception)
        //     {
        //         _logger.LogInformation($"PersonalServices:AddSkills()-{exception.Message}\n{exception.StackTrace}");
        //         return false;
        //     }


        // }
        public bool UpdateBreakDuration(BreakDuration duration)
        {
            if (duration == null) throw new ArgumentNullException($" ProfileService:Update()-user values not be null{duration}");

            try
            {
                duration.UpdatedBy = duration.CreatedBy;
                duration.UpdatedOn = DateTime.Now;
                return profileData.UpdateBreakDuration(duration);

            }

            catch (Exception exception)
            {
                _logger.LogInformation($"ProfileService:Update()-{exception.Message}\n{exception.StackTrace}");
                return false;

            }
        }
        // public bool RemoveBreakDuration(int BreakDuration_Id)
        // {
        //     if (BreakDuration_Id <= 0)
        //         throw new ArgumentNullException($"BreakDuration ID is not provided{BreakDuration_Id}");


        //     try
        //     {

        //         return profileData.RemoveBreakDuration(BreakDuration_Id) ? true : false;

        //     }

        //     catch (Exception exception)
        //     {
        //         _logger.LogInformation($"PersonalServices:Delete()-{exception.Message}\n{exception.StackTrace}");
        //         return false;
        //     }
        // }

        // public bool AddLanguage(Language language)
        // {
        //     if (language == null) throw new ArgumentNullException($"Values cannot be null values are {language}");

        //     try
        //     {
        //         language.CreatedOn = DateTime.Now;
        //         return profileData.AddLanguage(language) ? true : false;
        //     }
        //     catch (Exception exception)
        //     {
        //         _logger.LogInformation($"PersonalServices:AddSkills()-{exception.Message}\n{exception.StackTrace}");
        //         return false;
        //     }


        // }
        public bool UpdateLanguage(Language language)
        {
            if (language == null) throw new ArgumentNullException($" ProfileService:Update()-user values not be null{language}");

            try
            {
                language.UpdatedBy = language.CreatedBy;
                language.UpdatedOn = DateTime.Now;
                return profileData.UpdateLanguage(language);

            }

            catch (Exception exception)
            {
                _logger.LogInformation($"ProfileService:Update()-{exception.Message}\n{exception.StackTrace}");
                return false;

            }
        }

        // public bool RemoveLanguage(int Language_Id)
        // {
        //     if (Language_Id <= 0)



        //         try
        //         {

        //             return profileData.RemoveLanguage(Language_Id) ? true : false;

        //         }

        //         catch (Exception exception)
        //         {
        //             _logger.LogInformation($"PersonalServices:Delete()-{exception.Message}\n{exception.StackTrace}");
        //             return false;
        //         }
        // }
        // public bool AddSocialMedia(SocialMedia media)
        // {
        //     if (media == null) throw new ArgumentNullException($"Values cannot be null values are {media}");
        //     try
        //     {

        //         media.CreatedOn = DateTime.Now;
        //         return profileData.AddSocialMedia(media) ? true : false;
        //     }
        //     catch (Exception exception)
        //     {
        //         _logger.LogInformation($"PersonalServices:AddSkills()-{exception.Message}\n{exception.StackTrace}");
        //         return false;
        //     }
        // }
        public bool UpdateSocialMedia(SocialMedia media)
        {
            if (media == null) throw new ArgumentNullException($" ProfileService:Update()-user values not be null{media}");

            try
            {
                media.UpdatedBy = media.CreatedBy;
                media.UpdatedOn = DateTime.Now;
                return profileData.UpdateSocialMedia(media);

            }

            catch (Exception exception)
            {
                _logger.LogInformation($"ProfileService:Update()-{exception.Message}\n{exception.StackTrace}");
                return false;

            }
        }
        // public bool RemoveSocialMedia(int SocialMedia_Id)
        // {
        //     if (SocialMedia_Id <= 0)
        //         throw new ArgumentNullException($"SocialMedia ID is not provided{SocialMedia_Id}");


        //     try
        //     {

        //         return profileData.RemoveSocialMedia(SocialMedia_Id) ? true : false;

        //     }

        //     catch (Exception exception)
        //     {
        //         _logger.LogInformation($"PersonalServices:Delete()-{exception.Message}\n{exception.StackTrace}");
        //         return false;
        //     }
        // }



    }
}