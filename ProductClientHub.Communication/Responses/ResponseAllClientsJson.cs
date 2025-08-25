using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClientHub.Communication.Responses
{
    public class ResponseAllClientsJson
    {
        public List<ResponseShortClientJson> Clients { get; set; } = [];
    }
}
