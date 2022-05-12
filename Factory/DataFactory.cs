// using Profile65.Models;

// namespace Profile65
// {
//     public class DataFactory{
//         public static ProfileContext Getusercontext(){
//             return new ProfileContext();
//         }
//         public static ProfileData GetUserObject(ILogger<ProfileService> logger){
//             return new ProfileData(Getusercontext(),logger);
//         }
//          public static PersonalDetail GetUserModelObject(ILogger<ProfileService> logger)
//         {
//             return new PersonalDetail();
//         }
//         // public static UserValidation GetValidationObject(){
//         //     return new UserValidation();
//         // }
        
//     }
// }


namespace Profile65
{
    public class DataFactory
    {
        public static Context GetProfileContext()
        {
            return new Context();
        }
        public static ProfileData GetProfileData(ILogger<PersonalService> logger)
        {
            return new ProfileData(GetProfileContext(),logger);
        }
    }
}