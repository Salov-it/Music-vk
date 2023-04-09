using MediatR;
using MyRecommendationsService.persistance;

namespace MyRecommendationsService.Application.CQRS.Command.DeleteAudio
{
    public class DeleteAudioHandler : IRequestHandler<DeleteAudioCommand, string>
    {
        public async Task<string> Handle(DeleteAudioCommand request, CancellationToken cancellationToken)
        {
            if (request.DeleteAudio == "Delete")
            {


                using (Context db = new Context())
                {
                    var content = db.audios.ToList();
                    for (int i = 0; i < content.Count; i++)
                    {
                        var FileName = content[i].File;
                        if (File.Exists(FileName))
                        {
                            try
                            {
                                File.Delete(FileName);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("The deletion failed: {0}", e.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Specified file doesn't exist");
                        }

                    }


                }
            }

            return "Выполнено";
        }
    }
    
}
