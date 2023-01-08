using System;
using System.Collections.Generic;
using System.Text;

using System.Net;
using System.Net.Mail;
using System.Web;



using Kavenegar;

namespace DigiKala.Core.Classes
{    
    public class MessageSender
    {


        public void SMS(string to, string body)
        {
            var sender = "";
            var receptor = to;
            var message = body;
            var api = new KavenegarApi("");

            api.Send(sender, receptor, message);
        }

    }
}
