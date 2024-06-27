namespace DatePickerMemoryLeak;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OpenPageClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(TestPage), true, new Dictionary<string, object>());
	}
}

