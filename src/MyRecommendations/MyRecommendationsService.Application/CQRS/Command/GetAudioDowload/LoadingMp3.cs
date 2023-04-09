

using MyRecommendationsService.persistance;
using System.Diagnostics;

namespace MyRecommendationsService.Application.CQRS.Command.GetAudioDowload
{
    public class LoadingMp3
    {
        string param1 = "-y" + " " + "-i";
        string param2 = "-c:a copy";
        string param3 = ".mp3";
        string param4 = @"./mp3/";
        char max = '"';
        public string start { get; set; }

        public void LooadingMp3()
        {
            using (Context db = new Context())
            {
                var audios = db.audios.ToList();

                for (int i = 0; i < audios.Count; i++)
                {
                    var audioUril = audios[i].Urilvk;
                    var audioName = audios[i].Name;

                    string text = param1 + " " + audioUril + " " + param2 + " " + param4 + max + audioName + max + param3;
                    string text3 = string.Join(" ", text);

                    Process process = new Process();
                    string path6 = @"./ffmpeg/ffmpeg.exe";
                    process.StartInfo.FileName = path6;
                    process.StartInfo.Arguments = text3;
                    process.Start();
                    start = audioUril.ToString();



                }



            }

        }
    }
}
