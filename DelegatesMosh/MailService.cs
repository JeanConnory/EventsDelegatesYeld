﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesMosh
{
    public class MailService
    {
        public void OnVideoEncoded(object? source, VideoEventArgs? e) // EventArgs args
        {
            Console.WriteLine("MailService: Sending an email..." + e.Video?.Title);
        }
    }
}
