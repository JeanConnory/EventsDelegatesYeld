using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesMosh
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e) // EventArgs args
        {
            Console.WriteLine("MessageService: Sending a text message..." + e.Video?.Title);
        }
    }
}
