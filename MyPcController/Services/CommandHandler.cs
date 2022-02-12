using MyPcController.Models;

namespace MyPcController.Services
{
    public class CommandHandler
    {
        private readonly ILogger<CommandHandler> logger;

        public CommandHandler(ILogger<CommandHandler> logger)
        {
            this.logger = logger;
        }
        public void Handle(Command command)
        {
            switch(command)
            {
                case Command.Play:
                    logger.LogDebug("Play");
                    KeyboardEmulatorService.Play();
                    break;
                case Command.Shutdown:
                    logger.LogDebug("Shutdown");
                    ExternalProcessService.TurnOff();
                    break;
                case Command.VolumeUp:
                    logger.LogDebug("Volume up");
                    KeyboardEmulatorService.VolumeUp();
                    break;
                case Command.VolumeDown:
                    logger.LogDebug("Volume down");
                    KeyboardEmulatorService.VolumeDown();
                    break;
                default:
                    logger.LogError("Unknown command");
                    break;
            }
        }
    }
}
