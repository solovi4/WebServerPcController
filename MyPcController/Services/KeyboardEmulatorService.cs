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

        public static void VolumeUp(int increaseBy)
        {
            var keyboard = new InputSimulator().Keyboard;
            for(var i =0; i < increaseBy/2; i++)
                keyboard.KeyPress(VirtualKeyCode.VOLUME_UP);
        }

        public static void VolumeDown(int decreaseBy)
        {
            var keyboard = new InputSimulator().Keyboard;
            for (var i = 0; i < decreaseBy / 2; i++)
                keyboard.KeyPress(VirtualKeyCode.VOLUME_DOWN);
        }

        public static void Mute()
        {
            var keyboard = new InputSimulator().Keyboard;
            keyboard.KeyPress(VirtualKeyCode.VOLUME_MUTE);
        }
    }
}
