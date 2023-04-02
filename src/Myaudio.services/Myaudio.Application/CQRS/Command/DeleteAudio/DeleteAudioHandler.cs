using MediatR;
using Myaudio.Application.CQRS.Command.GetMyaudio;
using Myaudio.Domain;
using Myaudio.persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using File = System.IO.File;

namespace Myaudio.Application.CQRS.Command.DeleteAudio
{
    internal class DeleteAudioHandler : IRequestHandler<DeleteAudioCommand, string>
    {
        public async Task<string> Handle(DeleteAudioCommand request, CancellationToken cancellationToken)
        {
            if (request.DeleteAudio == "Delete")
            {


                using (MyaudiosContext db = new MyaudiosContext())
                {
                    var content = db.myaudios.ToList();
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
