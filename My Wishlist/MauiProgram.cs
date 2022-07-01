using My_Wishlist.Pages;
using My_Wishlist.ViewModels;

namespace My_Wishlist;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		
		// Serices

		// Permanent
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainViewModel>();

		// Temporary
		builder.Services.AddTransient<DetailPage>();
		builder.Services.AddTransient<DetailViewModel>();

        return builder.Build();
	}
}
