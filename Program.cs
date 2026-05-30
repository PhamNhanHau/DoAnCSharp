using DoAnCSharp.Models;
using Serilog;
using System.Runtime.CompilerServices;

namespace DoAnCSharp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File(
                    path: @"D:\Tool\Visual Studio\Project\DoAnCSharp\log.txt",//Duong dan
                    fileSizeLimitBytes: 1 * 1024 * 1024, //kich thuoc 1mb
                    rollOnFileSizeLimit: true,          //tao file backup khi day 1mb
                    retainedFileCountLimit: 5,          //toi da 1 file goc va 4 file backup
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] - {Message:lj}{NewLine}{Exception}"
                )
                .CreateLogger();
            Log.Information("Ứng dụng Quản lý Sinh viên bắt đầu khởi chạy.");


            
            ApplicationConfiguration.Initialize();
            QLSVModel model = new QLSVModel();
            QLSVView view = new QLSVView();
            QLSVController controller = new QLSVController(view, model);
            Application.Run(view);
            //Giai phong bo nho
            if (model.TrangThaiSQL) { controller.closeSQL(); }
            Log.CloseAndFlush();
        }
    }
}