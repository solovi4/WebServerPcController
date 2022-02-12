using System.Runtime.InteropServices;
using WindowsInput;
using WindowsInput.Native;

namespace MyPcController.Services
{
    
    public static class KeyboardEmulatorService
    {        
        public static void Play()
        {
            var keyboard = new InputSimulator().Keyboard;
            keyboard.KeyPress(VirtualKeyCode.MEDIA_PLAY_PAUSE);
        }

        public static void VolumeUp()
        {
            var keyboard = new InputSimulator().Keyboard;
            keyboard.KeyPress(VirtualKeyCode.VOLUME_UP);
            keyboard.KeyPress(VirtualKeyCode.VOLUME_UP);
        }

        public static void VolumeDown()
        {
            var keyboard = new InputSimulator().Keyboard;
            keyboard.KeyPress(VirtualKeyCode.VOLUME_DOWN);
            keyboard.KeyPress(VirtualKeyCode.VOLUME_DOWN);
        }
    }
}
