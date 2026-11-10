using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SeeShellsV3.UI
{
    public partial class ChatView : UserControl
    {
        private readonly ObservableCollection<ChatMessage> _messages = new ObservableCollection<ChatMessage>();

        public ChatView()
        {
            InitializeComponent();
            ChatMessages.ItemsSource = _messages;

            _messages.Add(new ChatMessage(
                "Assistant",
                "Hi! I can help you explore the ShellBag events in this investigation. This conversation is a UI preview; the LLM is not connected yet.",
                false));
            _messages.Add(new ChatMessage(
                "You · example",
                "What kinds of questions will I be able to ask?",
                true));
            _messages.Add(new ChatMessage(
                "Assistant · example",
                "Once connected, you could ask for a summary of the loaded events, ask about activity in a time range, or look for events associated with a location.",
                false));
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            SendMessage();
        }

        private void Composer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && !Keyboard.Modifiers.HasFlag(ModifierKeys.Shift))
            {
                e.Handled = true;
                SendMessage();
            }
        }

        private void SendMessage()
        {
            string text = Composer.Text.Trim();
            if (string.IsNullOrEmpty(text))
                return;

            _messages.Add(new ChatMessage("You", text, true));
            Composer.Clear();
            _messages.Add(new ChatMessage(
                "Assistant · preview",
                "This is a placeholder reply. Connect the LLM service here to generate a response.",
                false));
            ChatScrollViewer.ScrollToEnd();
            Composer.Focus();
        }
        
        private sealed class ChatMessage
        {
            public ChatMessage(string role, string text, bool isUser)
            {
                Role = role;
                Text = text;
                IsUser = isUser;
            }

            public string Role { get; }
            public string Text { get; }
            public bool IsUser { get; }
        }
    }
}