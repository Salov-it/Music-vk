using MediatR;

namespace MyRecommendationsService.Application.CQRS.Command.GetAudioDowload
{
    public class GetAudiosHandler : IRequestHandler<GetAudioDowloadCommand, string>
    {
        public async Task<string> Handle(GetAudioDowloadCommand request, CancellationToken cancellationToken)
        {
            //Очистка баз данных
            BaseDelete baseDelete = new BaseDelete();
            baseDelete.BasseDelet();
            // получения mp3
            Audios audio = new Audios();
            audio.GetAudio(request.CountAudio);
            //Загрузка mp3
            LoadingMp3 loadingMp3 = new LoadingMp3();
            loadingMp3.LooadingMp3();

            return "Загружаю";
        }
    }
}
