namespace DoAnCSharp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            QLSVView view = new QLSVView();
            QLSVController controller = new QLSVController(view);
            Application.Run(view);
        }
    }
}