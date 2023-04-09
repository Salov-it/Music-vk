
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.Intrinsics.X86;
using VkNet.Model.RequestParams;
using VkNet.Model;
using VkNet;
using VkNet.AudioBypassService.Extensions;

namespace MyRecommendationsService.Application.CQRS.Command.GetAudioDowload
{
    public class Audios
    {
        public string Title { get; set; }
        public string Uril { get; set; }
        public int Time { get; set; }
        public string File { get; set; }

        public void GetAudio(int CountAudio)
        {
            var services = new ServiceCollection();
            services.AddAudioBypass();

            var api = new VkApi(services);

            api.Authorize(new ApiAuthParams // в дальнейшем переделать на авторизацию по токену
            {
                ApplicationId = 7822351,
                Login = "89244452428",
                Password = "Salov1999"
            });

            var audios = api.Audio.GetRecommendations(count: (uint?)CountAudio);


            Basse basse = new Basse();
            for (int i = 0; i < audios.Count; i++) //полученмя название песни длитетльность ссылка uril
            {
                Title = audios[i].Title;
                Uril = audios[i].Url.ToString();
                Time = audios[i].Duration;
                File = @"./mp3/" + Title + ".mp3";

                basse.SaveBasse(Title, Uril, Time, File);
            }
        }
    }
    
}
