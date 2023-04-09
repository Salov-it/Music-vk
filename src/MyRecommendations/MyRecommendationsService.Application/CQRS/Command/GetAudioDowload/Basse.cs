using MyRecommendationsService.Domain;
using MyRecommendationsService.persistance;

namespace MyRecommendationsService.Application.CQRS.Command.GetAudioDowload
{
    public class Basse
    {
        public void SaveBasse(string Title, string Uril, int Time, string File)
        {
            using (Context db = new Context())
            {
                Audio Audios = new Audio
                {
                    Name = Title,
                    Time = Time,
                    Urilvk = Uril,
                    File = File
                };

                db.audios.Add(Audios);
                db.SaveChanges();
            }
        }
    }
}
