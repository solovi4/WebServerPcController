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
                case Command.VolumeUp4:
                    logger.LogDebug("Volume up");
                    KeyboardEmulatorService.VolumeUp(4);
                    break;
                case Command.VolumeUp10:
                    logger.LogDebug("Volume up");
                    KeyboardEmulatorService.VolumeUp(10);
                    break;
                case Command.VolumeUp20:
                    logger.LogDebug("Volume up");
                    KeyboardEmulatorService.VolumeUp(20);
                    break;
                case Command.VolumeUp40:
                    logger.LogDebug("Volume up");
                    KeyboardEmulatorService.VolumeUp(40);
                    break;
                case Command.VolumeUp100:
                    logger.LogDebug("Volume up");
                    KeyboardEmulatorService.VolumeUp(100);
                    break;
                case Command.VolumeDown4:
                    logger.LogDebug("Volume down");
                    KeyboardEmulatorService.VolumeDown(4);
                    break;
                case Command.VolumeDown10:
                    logger.LogDebug("Volume down");
                    KeyboardEmulatorService.VolumeDown(10);
                    break;
                case Command.VolumeDown20:
                    logger.LogDebug("Volume down");
                    KeyboardEmulatorService.VolumeDown(20);
                    break;
                case Command.VolumeDown40:
                    logger.LogDebug("Volume down");
                    KeyboardEmulatorService.VolumeDown(40);
                    break;
                case Command.Mute:
                    logger.LogDebug("Mute");
                    KeyboardEmulatorService.Mute();
                    break;
                default:
                    logger.LogError("Unknown command");
                    break;
            }
        }
    }
}
