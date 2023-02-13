using CommunityToolkit.Maui.Markup;
using Material.Components.Maui.Extensions;
using Material.Components.Maui.Tokens;
using Microsoft.Extensions.Logging;

namespace MauiApp9;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
                  .UseMauiApp<App>()
            .UseMaterialComponents(
                new List<string>
                {
                    "Roboto-Regular.ttf",
                    "Roboto-Italic.ttf",
                    "Roboto-Medium.ttf",
                    "Roboto-MediumItalic.ttf",
                    "Roboto-Bold.ttf",
                    "Roboto-BoldItalic.ttf",
                }
            )
            .UseMauiCommunityToolkitMarkup();

    FontMapper.AddFont("OpenSans-Regular.ttf", "OpenSans");


#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
