using MediatR;
using Myaudio.Application.CQRS.Command.GetMyaudio;


namespace Myaudio.Application.CQRS.Command.GetMyaudioDowload
{
    public class GetMyaudiosHandler : IRequestHandler<GetAudioDowloadCommand, string>
    {
        
        public async Task<string> Handle(GetAudioDowloadCommand request, CancellationToken cancellationToken)
        {
            //Очистка баз данных
            BaseDelete baseDelete = new BaseDelete();
            baseDelete.BasseDelet();
            // получения mp3
            Audio audio = new Audio();
            audio.GetAudio(request.CountAudio);
            //Загрузка mp3
            LoadingMp3 loadingMp3 = new LoadingMp3();
            loadingMp3.LooadingMp3();

            return "Загружаю";
        }
    }
}
