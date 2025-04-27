using chatWithRobot.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatWithRobot.ViewModels
{
    public class ChatsViewModel
    {
        public ObservableCollection<Chat> Chats { get; set; } = new ObservableCollection<Chat>();

        public ChatsViewModel()
        {
            // Начальные тестовые чаты
            Chats.Add(new Chat { Name = "Чат с Роботом 1" });
            Chats.Add(new Chat { Name = "Чат с Роботом 2" });
        }
    }
}
