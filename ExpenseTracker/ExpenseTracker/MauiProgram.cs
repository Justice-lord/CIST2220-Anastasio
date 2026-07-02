using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using ExpenseTracker.Services;
using ExpenseTracker.ViewModels;
using ExpenseTracker.Views;
using LiveChartsCore.SkiaSharpView.Maui;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace ExpenseTracker
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseSkiaSharp()
                .UseLiveCharts()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<DatabaseService>();

            builder.Services.AddTransient<AddTransactionViewModel>();
            builder.Services.AddTransient<AddTransactionPage>();
            builder.Services.AddTransient<TransactionsViewModel>();
            builder.Services.AddTransient<TransactionsPage>();
            builder.Services.AddTransient<DashboardViewModel>();
            builder.Services.AddTransient<DashboardPage>();

            return builder.Build();
        }
    }
}
