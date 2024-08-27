using CommunityToolkit.Mvvm.ComponentModel;

namespace UserControlIssue.ViewModels
{
	public partial class SubViewModel : ViewModelBase
	{
		[ObservableProperty] private string subProperty = "Sub Property";
	}
}
