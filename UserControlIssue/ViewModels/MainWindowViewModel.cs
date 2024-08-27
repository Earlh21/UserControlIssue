using CommunityToolkit.Mvvm.ComponentModel;

namespace UserControlIssue.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
	[ObservableProperty] private SubViewModel subViewModel = new();
}
