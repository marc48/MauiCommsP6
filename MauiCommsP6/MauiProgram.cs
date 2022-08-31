using MauiCommsP6.ViewModels;
using MauiCommsP6.Views;

namespace MauiCommsP6;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();

        // Toolkit.Maui
        //builder.UseMauiApp<App>().UseMauiCommunityToolkit();

        builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainPageViewModel>();
        builder.Services.AddSingleton<GestCommPage>();
        builder.Services.AddSingleton<GestCommViewModel>();

        return builder.Build();
	}
}
