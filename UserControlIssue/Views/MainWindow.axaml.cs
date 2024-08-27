using Avalonia.Controls;
using UserControlIssue.ViewModels;

namespace UserControlIssue.Views;

public partial class MainWindow : Window
{
	public MainWindow()
	{
		DataContext = new MainWindowViewModel();
		InitializeComponent();
	}
}
