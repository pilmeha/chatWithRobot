using chatWithRobot.Models;
using chatWithRobot.ViewModels;

namespace chatWithRobot.Views
{
    public partial class ChatsPage2 : ContentPage
    {
        public ChatsPage2()
        {
            InitializeComponent();
        }

        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Chat selectedChat)
            {
                await Navigation.PushAsync(new ChatPage2(selectedChat));
            }
        }
    }
}
