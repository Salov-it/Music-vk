using Myaudio.Application.CQRS.Command.GetMyaudio;
using Myaudio.Application.CQRS.Command.GetMyaudioDowload;
using MyaudioService.Test.Common;

namespace MyaudioService.Test.GetMyaudioDowload
{
    public class GetMyaudioDowloadTest : Base
    {
        [Fact]
        public async Task GetMyaudioDowload()
        {
            var handler = new GetMyaudiosHandler();

            var myaudios = await handler.Handle(
                new GetAudioDowloadCommand()
                {
                    CountAudio = 1
                },
                CancellationToken.None
            );

            Assert.Equal(myaudios[1], myaudios[6]);
        }
    }
}
