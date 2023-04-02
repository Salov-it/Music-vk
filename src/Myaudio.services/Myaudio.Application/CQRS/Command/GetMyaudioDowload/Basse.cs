using Myaudio.Domain;
using Myaudio.persistance;

namespace Myaudio.Application.CQRS.Command.GetMyaudio
{
    public class Basse
    {
        public void SaveBasse(string Title, string Uril, int Time, string File)
        {
            using(MyaudiosContext db = new MyaudiosContext())
            {
                Myaudios myaudios = new Myaudios
                {
                    Name = Title,
                    Time = Time,
                    Urilvk = Uril,
                    File = File
                };
                db.myaudios.Add(myaudios);
                db.SaveChanges();
            }
        }
    }
}
