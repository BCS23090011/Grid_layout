using Grid_layout.ViewModels; // 确保添加这个 using
using Microsoft.Extensions.Logging; // 您的文件顶部可能已经有这个

namespace Grid_layout
{
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

            // 您的文件在这里可能已经有下面这样的调试代码
            // 如果有，请保留它
#if DEBUG
            builder.Logging.AddDebug();
#endif

            // **** 您只需要添加下面这两行 ****
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<MainPage>();


            // **** 然后就是文件末尾的 return ****
            return builder.Build();
        }
    }
}