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
        SMTC smtc = new SMTC();

        private bool playing
        {
            get { return __playing; }
            set
            {
                __playing = value;
                smtc.Playing = value;
            }
        }

        public MusicPlayer_MediaPlayer()
        {
        }

        public SMTC SMTCObj
        {
            get { return smtc; }
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
            playing = true;
        }

        public void PlayMusic(Song song)
        {
            try
            {
                mediaPlayer.Open(new Uri(song.Address));
                mediaPlayer.Play();
                __nowPlaying = song;
                playing = true;
            }
            catch { }
        }

        public void LoadMusic(Song song)
        {
            try
            {
                mediaPlayer.Open(new Uri(song.Address));
                __nowPlaying = song;
                playing = false;
            }
            catch { }
        }

        public void PauseMusic()
        {
            mediaPlayer.Pause();
            playing = false;
        }

        public void SwitchPlayingStatus()
        {
            if (playing)
                this.PauseMusic();
            else
                this.PlayMusic();
        }

        public void UpdateSMTC(Musicinfo musicinfo)
        {
            smtc.UpdateMusicInfo(musicinfo);
        }
    }
}
