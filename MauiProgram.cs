using Microsoft.Extensions.Logging;
using MemoryToolkit.Maui;
using Syncfusion.Maui.Core.Hosting;

namespace DatePickerMemoryLeak;

public static class MauiProgram
{

	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.ConfigureSyncfusionCore();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();

		// Ensure UseLeakDetection is called after logging has been configured!
		builder.UseLeakDetection(collectionTarget =>
		{
			// This callback will run any time a leak is detected.
			Application.Current?.MainPage?.DisplayAlert("💦Leak Detected💦",
				$"❗🧟❗{collectionTarget.Name} is a zombie!", "OK");
		});
#endif

		builder.Services.AddTransient<TestPage>();

		return builder.Build();
	}
}
