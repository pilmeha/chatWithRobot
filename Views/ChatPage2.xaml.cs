using chatWithRobot.Models;
using chatWithRobot.ViewModels;

namespace chatWithRobot.Views
{
    public partial class ChatPage2 : ContentPage
    {
        public ChatPage2(Chat chat)
        {
            InitializeComponent();
            BindingContext = new ChatViewModel(chat);
        }
    }
}
