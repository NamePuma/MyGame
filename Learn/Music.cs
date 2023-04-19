using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Learn
{
    static class Music
    {
        private static WindowsMediaPlayer player = new WindowsMediaPlayer();
        static Music()
        {
            player.settings.autoStart = false;
            Loop();
        }
        public static void Go(string url)
        {
            player.URL = $@"{url}";
            player.controls.play();
        }
        public static void Loop(bool loop = true)
        {
            if(!loop)
            {
                player.settings.setMode("loop", false);
            }
            else
            {
                player.settings.setMode("loop", true);
            }
        }
        public static void Stop()
        {
            player.controls.stop();
        }
    }
}
