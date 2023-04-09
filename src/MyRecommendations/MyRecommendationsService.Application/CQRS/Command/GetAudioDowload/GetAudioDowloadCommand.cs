using MediatR;

namespace MyRecommendationsService.Application.CQRS.Command.GetAudioDowload
{
    public class GetAudioDowloadCommand : IRequest<string>
    {
        public int CountAudio { get; set; }
    }
}
