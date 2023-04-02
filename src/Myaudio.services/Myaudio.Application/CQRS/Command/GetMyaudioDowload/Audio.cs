using Microsoft.Extensions.DependencyInjection;
using VkNet.Model.RequestParams;
using VkNet.Model;
using VkNet;
using VkNet.AudioBypassService.Extensions;

namespace Myaudio.Application.CQRS.Command.GetMyaudio
{
    public class Audio
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

            var audios = api.Audio.Get(new AudioGetParams
            {
                Count = CountAudio,
            });

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
