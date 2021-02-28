using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;

namespace hello_avalonia
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void OnClick(object sender, RoutedEventArgs e)
        {
            // set message from entered text
            var Edit = this.FindControl<TextBox>("edit");
            var Message = this.FindControl<TextBlock>("message");
            Message.Text = $"Hello {Edit.Text}!";
        }
    }
}
