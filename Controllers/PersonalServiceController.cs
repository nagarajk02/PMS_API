
using Microsoft.AspNetCore.Mvc;

namespace Profile65
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class PersonalServiceController : Controller
    {
        private IPersonalService _personalService;
        private ILogger _logger;
        public PersonalServiceController(IPersonalService personalService, ILogger<PersonalServiceController> logger)
        {
            _personalService = personalService;
            _logger = logger;
        }
        
        [HttpPut]
        public IActionResult UpdatePersonalDetail(PersonalDetails personalDetails)

        {

            if (personalDetails == null)
            {
                // _logger.LogInformation("UserController :UpdateUser()-user tries to enter null values");
                return BadRequest("User values not be null");
            }

            //updating user via userservices

            try
            {

                return _personalService.UpdatePersonalDetail(personalDetails) ? Ok("User Updated Successfully") : BadRequest("Sorry internal error occured");

            }

            catch (Exception exception)
            {
                // _logger.LogInformation($"UserController:UpdateUser()-{exception.Message}{exception.StackTrace}");
                return BadRequest(exception.Message);
            }
        }

       

        [HttpPut]
        public IActionResult UpdateEducation(Education education)

        {

            if (education == null)
            {
                // _logger.LogInformation("UserController :UpdateUser()-user tries to enter null values");
                return BadRequest("User values not be null");
            }

            //updating user via userservices

            try
            {

                return _personalService.UpdateEducation(education) ? Ok("User Updated Successfully") : BadRequest("Sorry internal error occured");

            }

            catch (Exception exception)
            {
                // _logger.LogInformation($"UserController:UpdateUser()-{exception.Message}{exception.StackTrace}");
                return BadRequest(exception.Message);
            }
        }

        
        [HttpPut]
        public IActionResult UpdateProjects(Projects projects)

        {

            if (projects == null)
            {
                // _logger.LogInformation("UserController :UpdateUser()-user tries to enter null values");
                return BadRequest("User values not be null");
            }

            //updating user via userservices

            try
            {

                return _personalService.UpdateProjects(projects) ? Ok("User Updated Successfully") : BadRequest("Sorry internal error occured");

            }

            catch (Exception exception)
            {
                // _logger.LogInformation($"UserController:UpdateUser()-{exception.Message}{exception.StackTrace}");
                return BadRequest(exception.Message);
            }
        }
        
        [HttpPut]
        public IActionResult UpdateSkills(Skills skill)

        {

            if (skill == null)
            {
                // _logger.LogInformation("UserController :UpdateUser()-user tries to enter null values");
                return BadRequest("User values not be null");
            }

            //updating user via userservices

            try
            {

                return _personalService.UpdateSkills(skill) ? Ok("User Updated Successfully") : BadRequest("Sorry internal error occured");

            }

            catch (Exception exception)
            {
                // _logger.LogInformation($"UserController:UpdateUser()-{exception.Message}{exception.StackTrace}");
                return BadRequest(exception.Message);
            }
        }
        
        [HttpPut]
        public IActionResult UpdateBreakDuration(BreakDuration duration)

        {

            if (duration == null)
            {
                // _logger.LogInformation("UserController :UpdateUser()-user tries to enter null values");
                return BadRequest("User values not be null");
            }

            //updating user via userservices

            try
            {

                return _personalService.UpdateBreakDuration(duration) ? Ok("User Updated Successfully") : BadRequest("Sorry internal error occured");

            }

            catch (Exception exception)
            {
                // _logger.LogInformation($"UserController:UpdateUser()-{exception.Message}{exception.StackTrace}");
                return BadRequest(exception.Message);
            }
        }
        
        [HttpPut]
        public IActionResult UpdateLanguage(Language language)
        {
            if (language == null)
            {
                // _logger.LogInformation("UserController :UpdateUser()-user tries to enter null values");
                return BadRequest("User values not be null");
            }

            //updating user via userservices

            try
            {

                return _personalService.UpdateLanguage(language) ? Ok("User Updated Successfully") : BadRequest("Sorry internal error occured");

            }

            catch (Exception exception)
            {
                // _logger.LogInformation($"UserController:UpdateUser()-{exception.Message}{exception.StackTrace}");
                return BadRequest(exception.Message);
             }
        }
       
        [HttpPut]
        public IActionResult UpdateSocialMedia(SocialMedia media)
        {
            if (media == null)
            {
                // _logger.LogInformation("UserController :UpdateUser()-user tries to enter null values");
                return BadRequest("User values not be null");
            }

            //updating user via userservices

            try
            {

                return _personalService.UpdateSocialMedia(media) ? Ok("User Updated Successfully") : BadRequest("Sorry internal error occured");

            }

            catch (Exception exception)
            {
                // _logger.LogInformation($"UserController:UpdateUser()-{exception.Message}{exception.StackTrace}");
                return BadRequest(exception.Message);
             }
        }

        
    }
}

// using Microsoft.AspNetCore.Mvc;
// using Profile65.Models;

// namespace Profile65.Controllers;

// [ApiController]
// [Route("[controller]")]

// public class ProfileController : Controller
// {
//     private IProfileService _personalService;
//     private ILogger _logger;
//     public ProfileController(IProfileService userServices,ILogger<ProfileController> logger)
//     { //
//         _personalService = userServices;
//         _logger = logger;

//     }
//     [HttpGet]

//     public IActionResult GetUserById(int id)
//     {
//         try
//         {

//             return Ok(_personalService.GetUser(id));
//         }
//         catch (Exception exception)
//         {
//             // _logger.LogInformation($"UserController :GetUserById()- exception occured while fetching record{exception.Message}{exception.StackTrace}");
//             return BadRequest(exception.Message);
//         }
//     }


//     [HttpPut]
//     public IActionResult UpdatePersonalDetail(PersonalDetail user)

//     {

//         if (user == null)
//         {
//             // _logger.LogInformation("UserController :UpdateUser()-user tries to enter null values");
//             return BadRequest("User values not be null");
//         }

//         //updating user via userservices

//         try
//         {

//             return _personalService.UpdatePersonalDetail(user) ? Ok("User Updated Successfully") : BadRequest("Sorry internal error occured");

//         }

//         catch (Exception exception)
//         {
//             // _logger.LogInformation($"UserController:UpdateUser()-{exception.Message}{exception.StackTrace}");
//             return BadRequest(exception.Message);
//         }
//     }
//     public IActionResult UpdateEducationDetail(EducationDetail user)

//     {

//         if (user == null)
//         {
//             // _logger.LogInformation("UserController :UpdateUser()-user tries to enter null values");
//             return BadRequest("User values not be null");
//         }

//         //updating user via userservices

//         try
//         {

//             return _personalService.UpdateEducationalDetail(user) ? Ok("User Updated Successfully") : BadRequest("Sorry internal error occured");

//         }

//         catch (Exception exception)
//         {
//             // _logger.LogInformation($"UserController:UpdateUser()-{exception.Message}{exception.StackTrace}");
//             return BadRequest(exception.Message);
//         }
//     }
//      public IActionResult UpdateProjectDetail(Pro user)

//     {

//         if (user == null)
//         {
//             // _logger.LogInformation("UserController :UpdateUser()-user tries to enter null values");
//             return BadRequest("User values not be null");
//         }

//         //updating user via userservices

//         try
//         {

//             return _personalService.UpdateProjectDetail(user) ? Ok("User Updated Successfully") : BadRequest("Sorry internal error occured");

//         }

//         catch (Exception exception)
//         {
//             // _logger.LogInformation($"UserController:UpdateUser()-{exception.Message}{exception.StackTrace}");
//             return BadRequest(exception.Message);
//         }
//     }
//      public IActionResult UpdateSkill(EducationDetail user)

//     {

//         if (user == null)
//         {
//             // _logger.LogInformation("UserController :UpdateUser()-user tries to enter null values");
//             return BadRequest("User values not be null");
//         }

//         //updating user via userservices

//         try
//         {

//             return _personalService.UpdateSkill(user) ? Ok("User Updated Successfully") : BadRequest("Sorry internal error occured");

//         }

//         catch (Exception exception)
//         {
//             // _logger.LogInformation($"UserController:UpdateUser()-{exception.Message}{exception.StackTrace}");
//             return BadRequest(exception.Message);
//         }
//     }

// }