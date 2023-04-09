using MediatR;
using MyRecommendationsService.Domain;
using MyRecommendationsService.persistance;

namespace MyRecommendationsService.Application.CQRS.Querries.GetAudio
{
    public class GetAudioHandler : IRequestHandler<GetAudioCommanda, List<Audio>>
    {
        public List<Audio> Content { get; set; }

        public async Task<List<Audio>> Handle(GetAudioCommanda request, CancellationToken cancellationToken)
        {
            using (Context db = new Context())
            {
                Content = db.audios.ToList();
            }

            return Content;
        }
    }
}
