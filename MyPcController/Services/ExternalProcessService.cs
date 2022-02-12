using System.Diagnostics;

namespace MyPcController.Services
{
    public static class ExternalProcessService
    {
        public static void TurnOff()
        {
            Process.Start("shutdown", "/s /t 0");
        }
    }
}
