using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatWithRobot.Models
{
    public class Message
    {
        public string Sender { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
