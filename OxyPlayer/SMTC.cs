using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media;
using Windows.Media.Playback;

namespace OxyPlayer
{
    internal class SMTC
    {
        SystemMediaTransportControls __smtc;
        MediaPlayer __mediaplayer = new MediaPlayer();
        public SMTC()
        {
            //__mediaplayer.CommandManager.IsEnabled = false;
            __smtc = __mediaplayer.SystemMediaTransportControls;
        }

        public SystemMediaTransportControls SMTCObject 
        {
            get { return __smtc; }
        }
    }
}
