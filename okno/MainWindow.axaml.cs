using Avalonia.Controls;
using Avalonia.Interactivity;

namespace okno;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnButtonClick(object? sender, RoutedEventArgs e)
    {
        if (sender is Button button)
        {
            button.Content = "Kliknięto!";
        }
    }
}