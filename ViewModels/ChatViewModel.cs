using chatWithRobot.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace chatWithRobot.ViewModels
{
    public class ChatViewModel
    {
        private static readonly string RobotName = "Робот";
        private static readonly string UserName = "Пользователь";

        private static readonly string[] RobotResponses =
        {
            "Привет! Как дела?",
            "Я робот, приятно познакомиться!",
            "Чем могу помочь?"
        };

        public Chat Chat { get; set; }

        public ObservableCollection<Message> Messages => Chat.Messages;

        public string NewMessageText { get; set; }

        public ICommand SendMessageCommand { get; }

        public ChatViewModel(Chat chat)
        {
            Chat = chat;
            SendMessageCommand = new Command(SendMessage);
        }

        private void SendMessage()
        {
            if (string.IsNullOrWhiteSpace(NewMessageText))
                return;

            // Добавляем сообщение пользователя
            Messages.Add(new Message
            {
                Sender = UserName,
                Text = NewMessageText,
                Date = DateTime.Now
            });

            NewMessageText = string.Empty;

            // Автоматический ответ от робота
            var random = new Random();
            var response = RobotResponses[random.Next(RobotResponses.Length)];

            Messages.Add(new Message
            {
                Sender = RobotName,
                Text = response,
                Date = DateTime.Now
            });
        }
    }
}
