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
            var api = new KavenegarApi("38433151436B757833767779396A4847425246304669633144766B334E38326C5052445566493257356E343D");

            api.Send(sender, receptor, message);
        }

    }
}
