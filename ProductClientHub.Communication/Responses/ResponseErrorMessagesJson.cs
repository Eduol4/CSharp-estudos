using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClientHub.Communication.Responses
{
    public class ResponseErrorMessagesJson
    {
        public List<String> Errors { get; private set; }

        public ResponseErrorMessagesJson (string message)
        {
            //Errors = new List<string> { message };
            Errors = [message];
        }

        public ResponseErrorMessagesJson(List<string> messages)
        {
            Errors = messages;
        }
    }
}
