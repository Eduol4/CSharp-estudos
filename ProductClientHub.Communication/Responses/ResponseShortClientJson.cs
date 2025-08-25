using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClientHub.Communication.Responses
{
    public class ResponseShortClientJson
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
