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
using Windows.Storage.Streams;

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
            __smtc.IsEnabled = true;
            __smtc.IsPlayEnabled = true;
            __smtc.IsPauseEnabled = true;
            __smtc.IsNextEnabled = true;
            __smtc.IsPreviousEnabled = true;
        }

        public SystemMediaTransportControls SMTCObject
        {
            get { return __smtc; }
        }

        public void UpdateMusicInfo(Musicinfo musicinfo)
        {
            var updater = __smtc.DisplayUpdater;
            using (MemoryStream memory = new MemoryStream())
            {
                using (var tempImage = new Bitmap(musicinfo.Cover))
                {
                    updater.AppMediaId = "OxyPlayer";
                    updater.Type = MediaPlaybackType.Music;
                    updater.MusicProperties.Title = musicinfo.Title;
                    updater.MusicProperties.Artist = musicinfo.Artist;
                    updater.MusicProperties.AlbumTitle = musicinfo.Album;

                    tempImage.Save(memory, ImageFormat.Jpeg);
                    updater.Thumbnail = RandomAccessStreamReference.CreateFromStream(memory.AsRandomAccessStream());
                    updater.Update();//最后调用以生效
                }
            }
        }
    }
}
