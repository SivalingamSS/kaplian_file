namespace Authorization.Modal
{
    public class UserLogin
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public class UserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
    public class UserConstants
    {
        public static List<UserModel> Users = new()
            {
                    new UserModel(){ Username="Kabilan",Password="Kabilan",Role="Admin"}
            };
    }
}
