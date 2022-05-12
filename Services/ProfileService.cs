// using PMS.API;
// using Profile65.Models;

// namespace Profile65
// {
//     public class ProfileService : IProfileService
//     {
//         private ProfileData _profileData;

//         private ILogger<ProfileService> _logger;
//         public ProfileService(ILogger<ProfileService> logger)
//         {
//             _logger = logger;
//             _profileData = DataFactory.GetUserObject(logger);
//         }

    
//         public PersonalDetail GetUser(int id)
//         {
//             if(id<=0)throw new ArgumentNullException($"ID is not provided{id}");           
                
//             try {

//                 return _profileData.GetUser(id); 
//             }   
//             catch(Exception exception)
//             {
//                 _logger.LogError($"ProfileService:GetUser()-{exception.Message}\n{exception.StackTrace}");
//                 throw exception ;
//             }
            
//         }
//         public bool UpdatePersonalDetail(PersonalDetail item)
//         {
//             if(item==null)throw new ArgumentNullException($" ProfileService:Update()-user values not be null{item}");
//             // _validation.userValidate(item);
//             try
//             {
//                 item.UpdatedBy=item.User.Name;
//                 item.UpdatedOn=DateTime.Now;
//                 return _profileData.UpdatePersonalDetail(item);
                
//             }
            
//             catch(Exception exception){
//                  _logger.LogInformation($"ProfileService:Update()-{exception.Message}\n{exception.StackTrace}");
//                 return false;

//             }
//         }
//         public bool UpdateEducationalDetail(EducationDetail item)
//         {
//             if(item==null)throw new ArgumentNullException($" ProfileService:Update()-user values not be null{item}");
//             // _validation.userValidate(item);
//             try
//             {
//                 // item.UpdatedBy=;
//                 item.UpdatedOn=DateTime.Now;
//                 return _profileData.UpdateEducationlDetail(item);
                
//             }
            
//             catch(Exception exception){
//                  _logger.LogInformation($"ProfileService:Update()-{exception.Message}\n{exception.StackTrace}");
//                 return false;

//             }
//         }

        

//         public bool UpdateSkill(Skill item)
//         {
//             if(item==null)throw new ArgumentNullException($" ProfileService:Update()-user values not be null{item}");
//             // _validation.userValidate(item);
//             try
//             {
//                 // item.UpdatedBy=;
//                 item.UpdatedOn=DateTime.Now;
//                 return _profileData.UpdateSkill(item);
                
//             }
            
//             catch(Exception exception){
//                  _logger.LogInformation($"ProfileService:Update()-{exception.Message}\n{exception.StackTrace}");
//                 return false;

//             }
//         }

//         public bool UpdateProjectDetail(Projects item)
//         {
//             if(item==null)throw new ArgumentNullException($" ProfileService:Update()-user values not be null{item}");
//             // _validation.userValidate(item);
//             try
//             {
//                 // item.UpdatedBy=;
//                 item.UpdatedOn=DateTime.Now;
//                 return _profileData.UpdateProjectDetail(item);
                
//             }
            
//             catch(Exception exception){
//                  _logger.LogInformation($"ProfileService:Update()-{exception.Message}\n{exception.StackTrace}");
//                 return false;

//             }
//         }
//     }
// }

        
    
    

        
    
 