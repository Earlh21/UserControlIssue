using CommunityToolkit.Mvvm.ComponentModel;

namespace UserControlIssue.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
	[ObservableProperty] private string mainProperty = "Main Property";
	[ObservableProperty] private SubViewModel subViewModel = new();
}
