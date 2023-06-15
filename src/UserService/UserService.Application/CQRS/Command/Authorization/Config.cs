

namespace UserService.Application.CQRS.Command.Authorization
{
    public static class Config
    {
        public static string Uril = " https://oauth.vk.com/token";

        public static string grant_type = "password";

        public static int client_id = 7822351;

        public static string client_secret = "G7uzMuH2hjtbecB6CkQl";
        public static double v = 5.131;

        public static string username { get; set; }
        public static string Username
        {
            get { return username; }
            set { username = value; }
        }
        
        public static string password { get; set; }

        public static string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
