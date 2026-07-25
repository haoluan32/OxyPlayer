using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Media;
using Windows.Media;
using Windows.Media.Playback;
using Windows.Services.Maps;


namespace OxyPlayer
{
    public class MusicPlayer_MediaPlayer
    {
        System.Windows.Media.MediaPlayer mediaPlayer = new System.Windows.Media.MediaPlayer();
        private bool __playing = false;
        private Song __nowPlaying;
        

        public MusicPlayer_MediaPlayer()
        {
        }

        public System.Windows.Media.MediaPlayer MediaPlayer 
        {
            get 
            {
                return mediaPlayer;
            }
        }

        public string Position_String
        {
            get
            {
                return MusicSh.Second2MMSS(mediaPlayer.Position);
            }
        }

        public int Position_Int
        {
            get
            {
                return MusicSh.MMSS2Second(MusicSh.Second2MMSS(mediaPlayer.Position));
            }
            set
            {
                mediaPlayer.Position = new TimeSpan(0, 0, value);
            }
        }

        public bool PlayingStatus
        {
            get
            {
                return __playing;
            }
        }

        public Song NowPlaying
        {
            get
            {
                return __nowPlaying;
            }
        }

        public void PlayMusic()
        {
            mediaPlayer.Play();
            __playing = true;
        }

        public void PlayMusic(Song song)
        {
            try
            {
                mediaPlayer.Open(new Uri(song.Address));
                mediaPlayer.Play();
                __nowPlaying = song;
                __playing = true;
            }
            catch { }
        }

        public void LoadMusic(Song song)
        {
            try
            {
                mediaPlayer.Open(new Uri(song.Address));
                __nowPlaying = song;
                __playing = false;
            }
            catch { }
        }

        public void PauseMusic()
        {
            mediaPlayer.Pause();
            __playing = false;
        }

        public void SwitchPlayingStatus()
        {
            if (__playing)
                this.PauseMusic();
            else
                this.PlayMusic();
        }
    }
}
