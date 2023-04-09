using MyRecommendationsService.persistance;
using Microsoft.EntityFrameworkCore;
using MyRecommendationsService.Domain;

namespace MyRecommendationsService.Application.CQRS.Command.GetAudioDowload
{
    public class BaseDelete
    {
        public void BasseDelet()
        {
            using (Context db = new Context())
            {
                Audio? Audios = db.audios.FirstOrDefault();

                //удаляем объект
                db.audios.RemoveRange(db.audios);
                db.SaveChanges();

            }
        }
    }
}
