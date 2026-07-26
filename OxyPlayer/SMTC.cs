using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media;
using Windows.Media.Playback;
using Windows.Storage;
using Windows.Storage.Streams;

namespace OxyPlayer
{
    public class SMTC
    {
        SystemMediaTransportControls __smtc;
        MediaPlayer __mediaplayer = new MediaPlayer();
        public int Pressed = 255;
        public bool __playing = false;
        public bool Playing
        {
            get { return __playing; }
            set
            {
                if (value)
                {
                    __smtc.PlaybackStatus = MediaPlaybackStatus.Playing;
                }
                else
                {
                    __smtc.PlaybackStatus = MediaPlaybackStatus.Paused;
                }
                __playing = value;
            }
        }

        public SMTC()
        {
            //__mediaplayer.CommandManager.IsEnabled = false;
            __smtc = __mediaplayer.SystemMediaTransportControls;
            __smtc.IsEnabled = true;
            __smtc.IsPlayEnabled = true;
            __smtc.IsPauseEnabled = true;
            __smtc.IsNextEnabled = true;
            __smtc.IsPreviousEnabled = true;

            __smtc.ButtonPressed += __smtc_ButtonPressed;
        }

        private void __smtc_ButtonPressed(SystemMediaTransportControls sender, SystemMediaTransportControlsButtonPressedEventArgs args)
        {
            Pressed = (int)args.Button;
        }

        public SystemMediaTransportControls SMTCObject
        {
            get { return __smtc; }
        }

        public async Task UpdateMusicInfo(Musicinfo musicinfo)
        {
            var updater = __smtc.DisplayUpdater;
            InMemoryRandomAccessStream accessStream = new InMemoryRandomAccessStream();
            using (MemoryStream memory = new MemoryStream())
            {
                using (var tempImage = new Bitmap(musicinfo.Cover, new Size(512, 512)))
                {
                    updater.AppMediaId = "OxyPlayer";
                    updater.Type = MediaPlaybackType.Music;
                    updater.MusicProperties.Title = musicinfo.Title;
                    updater.MusicProperties.Artist = musicinfo.Artist;
                    updater.MusicProperties.AlbumTitle = musicinfo.Album;

                    tempImage.Save(memory, ImageFormat.Bmp);
                    memory.Position = 0;
                    memory.CopyTo(accessStream.AsStreamForWrite());

                    updater.Thumbnail = RandomAccessStreamReference.CreateFromStream(accessStream);
                    updater.Update();//最后调用以生效
                }
            }
        }
    }
}
