using Myaudio.Domain;
using Myaudio.persistance;

namespace Myaudio.Application.CQRS.Command.GetMyaudio
{
    public class BaseDelete
    {
       public void BasseDelet()
        {
            using(MyaudiosContext db = new MyaudiosContext())
            {
                Myaudios? myaudios = db.myaudios.FirstOrDefault();

                //удаляем объект
                db.myaudios.RemoveRange(db.myaudios);
                db.SaveChanges();
              
            }
        }
    }
}
