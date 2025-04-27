using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatWithRobot.Models
{
    public class Chat
    {
        public string Name { get; set; }
        public ObservableCollection<Message> Messages { get; set; } = new ObservableCollection<Message>();

        public Message LastMessage => Messages.Count > 0 ? Messages[^1] : null;
    }
}
