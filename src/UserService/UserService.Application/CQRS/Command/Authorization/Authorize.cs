using Microsoft.Win32.SafeHandles;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Enums.SafetyEnums;
using VkNet.Model;

namespace UserService.Application.CQRS.Command.Authorization
{
    public class Authorize
    {
        static HttpClient httpClient = new HttpClient();

        public async Task Authoriz(string Login, string Password)
        {
            Config.Username = Login;
            Config.Password = Password;

            StringContent content = new StringContent($"grant_type=password&client_id={Config.client_id}&client_secret={Config.client_secret}&username={Config.username}&password={Config.password}&v={Config.v}");
            //using var request = new HttpRequestMessage(HttpMethod.Post,Config.Uril);

            var response = await httpClient.PostAsync(Config.Uril,content);

            var responseContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseContent);
        }
    }   
}
