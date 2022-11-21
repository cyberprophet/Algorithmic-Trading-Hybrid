﻿using DevExpress.Maui;

using Microsoft.Maui.Controls.Compatibility.Hosting;

using ShareInvest.Configures;

namespace ShareInvest;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .UseDevExpress()
            .UseMauiCompatibility()
            .ConfigureEssentials(o =>
            {
                o.UseVersionTracking();
            })
            .ConfigureServices()
            .ConfigureViewModels()
            .ConfigurePages()
            .ConfigureFonts(o =>
            {
                o.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                o.AddFont("univia-pro-regular.ttf", "Univia-Pro");
                o.AddFont("roboto-bold.ttf", "Roboto-Bold");
                o.AddFont("roboto-regular.ttf", "Roboto");
            });
        return builder.Build();
    }
}