namespace Encrypt_Data.RollModal
{
    public class UserModal
    {
        public string User_Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
    public class UserLogin
    {
        public string User_Name { get; set; }
        public string Password { get; set; }
        
    }
    public class UserConstants
    {
        public static List<UserModal> Users = new()
        {
             new UserModal(){ User_Name ="Kabilan",Password="Kabilan",Role="Admin"}
        };
    }
}
