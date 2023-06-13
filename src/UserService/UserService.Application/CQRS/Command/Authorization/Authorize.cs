using Microsoft.Win32.SafeHandles;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;

namespace UserService.Application.CQRS.Command.Authorization
{
    public class Authorize
    {
       

        public async Task Authoriz(string login, string password)
        {
            VkApi api = new VkApi();
            api.Authorize(new ApiAuthParams { Login = login, Password = password });
        }
    }   
}
