using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kevya.Models
{
    public class Greetings
    {
        public List<Message> messages { get; set; }
    }
    public class Message
    {
        public string message { get; set; }
    }


}
