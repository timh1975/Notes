namespace Notes;
using Notes.Views;
using Notes.DataBase;

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

		builder.Services.AddSingleton<NotePage>();
		builder.Services.AddTransient<NotePage>();
		builder.Services.AddSingleton<NoteTable>();


		return builder.Build();
	}
}
