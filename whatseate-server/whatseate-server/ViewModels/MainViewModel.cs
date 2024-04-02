
using Microsoft.Extensions.Options;
using whatseate_server.Configuration;

namespace whatseate_server.ViewModels;

public class MainViewModel
{
	public string? Title { get; }

	public MainViewModel(
		INavigator navigator,
		IOptions<AppConfig> appInfo)
	{ 
	
		_navigator = navigator;
		Title = $"Main - {appInfo?.Value?.Title}";
	}

	public async Task GoToSecondPage()
	{
		await _navigator.NavigateViewModelAsync<SecondViewModel>(this);
	}

	private INavigator _navigator;
}
