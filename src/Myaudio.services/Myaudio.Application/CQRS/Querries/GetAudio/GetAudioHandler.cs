

using MediatR;
using Myaudio.Application.CQRS.Command.GetMyaudio;
using Myaudio.Domain;
using Myaudio.persistance;
using Newtonsoft.Json;

namespace Myaudio.Application.CQRS.Querries.GetAudio
{
    public class GetAudioHandler : IRequestHandler<GetAudioCommanda, List<Myaudios>>
    {
        public List<Myaudios> Content { get; set; }

        public async Task <List<Myaudios>> Handle(GetAudioCommanda request, CancellationToken cancellationToken)
        {
            using (MyaudiosContext db = new MyaudiosContext())
            {
                Content = db.myaudios.ToList();
            }
                
            return Content;
        }
    }
}
