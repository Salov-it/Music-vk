using Microsoft.EntityFrameworkCore;
using Myaudio.Domain;
using Myaudio.persistance;
using System;

namespace MyaudioService.Test.Common
{
    public class ContextFactory
    {
        
        public static Context Create()
        {
            var opt = new DbContextOptionsBuilder<Context>()
                .UseInMemoryDatabase("1")
                .Options;

            var context = new Context(opt);
            context.Database.EnsureCreated();

            var myaudis = GetMyaudios();
            context.Myaudio.AddRange(myaudis);
            context.SaveChanges();

            return context;
        }

        public static void Destroy(Context context)
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }

        public static Myaudios[] GetMyaudios()
        {
            var myaudios = new Myaudios[]
            {
                new Myaudios()
                {   
                    Urilvk = "https://cs2-8v4.vkuseraudio.net/s/v1/ac/18EJ6q6_bAiapmn3RoRS5lySxgpTpBf2cSmNERGWRVzghEKgR2PvGjMw0oTa6kE2KRqUrowXvpNyLwalPucD-wDz0N2AaQddfuUpEa9YHxJak33NQO5N5Hg5y2-STnYTKTpTIEO5bsuxfwRf8cjgDkKVu8wzxszqfXLxSg3Yf4RQ1So/index.m3u8",
                    Name = "Taking Over Me",
                    Time = 228,
                    File = "./mp3/Taking Over Me.mp3"
                },
                new Myaudios()
                {   
                    Urilvk = "https://cs2-11v4.vkuseraudio.net/s/v1/ac/kL59_gScmpStQDboQfX4ijaxHiJp8O_chDM2ysGKVQALCY4UgzTG46pi8cHD4kTp-Xnh_Tg2b29ZXfaMDUSXoA__g4eBrHbIvFX_cPbSs4OfvPKUjn4mkLodnIdSMBDEnm6TSaEcqRfIsvQKMaDaMzeHbQCo036s9DPKPkx5ukfkvqU/index.m3u8",
                    Name = "Айтишник",
                    Time = 130,
                    File = "./mp3/Айтишник.mp3"
                },

                new Myaudios()
                { 
                    Urilvk = "https://cs2-3v4.vkuseraudio.net/s/v1/ac/USuZOh8pydvzpMO0J-VzvaUJhCIQkb4wRY5PQRrKFzbuE1v7gD4ntmNNb86x7K-P0r5BabOLR8iCJGlW5ojZMjEv_IniblJ53M1deYIzePH71sd1267QlYc-y5shCNuakph1olhhBFpEM8ErFBjAMvx2wLqLkzSusg5kQVyYesFupe4/index.m3u8",
                    Name = "Покажи мне",
                    Time = 97,
                    File = "./mp3/Покажи мне.mp3"
                },

                new Myaudios()
                {
                    Urilvk = "https://cs2-16v4.vkuseraudio.net/s/v1/ac/18OyAY70otwASBCLwVR3H17H8TyhXqGo8R6w466FQk8glrrEmp-Yl5z2h9OFdmRIK62b77t1FhTgpsjVVG0xTCfFVQlM6_YboaIpeWBRq2nlw3dpWs9kSXYPgOJS9Hc4tEpUXSxEqjsPBN1YArguZlMQO_cZqEoYSkBXGVJ_rOYma0A/index.m3u8",
                    Name = "Сердца из стали",
                    Time = 302,
                    File = "./mp3/Сердца из стали.mp3"
                },

                new Myaudios()
                {
                    Urilvk = "https://cs2-13v4.vkuseraudio.net/s/v1/ac/Hbo95cAqY0rrdH8sWC5-WV93trwvATcaflzDtzQXH9-Mx0-sz8hoSr9oXYt5T78qbjFJv3AWYSdbNFFFDiWTscPPFedlshcPKssAhhZI508OBf9EW1TqcSQftC9Trdg94QNdyLWlDeigoE2Uu4tttcgW6p9XXE6JhfAIceo6b5dtmsY/index.m3u8",
                    Name = "Никотин",
                    Time = 150,
                    File = "./mp3/Никотин.mp3"
                }
            };
            return myaudios;
        }

    }
}
