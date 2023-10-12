using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesMosh
{
    public class VideoEncoder
    {
        //1 - Definir delegate
        //2 - Definir o evento
        //3 - Disparar o evento

        //public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //EventHandler
        //EventHandler<TEventArgs>
        
        //public event VideoEncodedEventHandler? VideoEncoded;
        public event EventHandler<VideoEventArgs>? VideoEncoded; //Com dados adicionais tipo o Video
        //public event EventHandler? VideoEncoding; //Sem dados adicionais tipo o Video

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video});
        }
    }
}
