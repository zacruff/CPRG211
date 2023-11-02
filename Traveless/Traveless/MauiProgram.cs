using Microsoft.AspNetCore.Components.WebView.Maui;
using Traveless.Backend;
using Traveless.Backend.Entities;

namespace Traveless;

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
			});

		builder.Services.AddMauiBlazorWebView();
		builder.Services.AddTransient<FlightManager>();
		builder.Services.AddTransient<AirlineManager>();
		builder.Services.AddTransient<AirportManager>();
		builder.Services.AddTransient<ReservationManager>();
		builder.Services.AddTransient<Reservation>();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif

		return builder.Build();
	}
}
