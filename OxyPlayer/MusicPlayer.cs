using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore;
using System.Threading;
using CSCore.Codecs;
using CSCore.SoundOut;

namespace OxyPlayer
{
    class MusicPlayer
    {
        WasapiOut soundOut = new WasapiOut();



        public MusicPlayer()
        {
            
        }

        public void Play(string Uri)
        {
            soundOut.Stop();
            IWaveSource audioSource = CodecFactory.Instance.GetCodec(Uri);
            soundOut.Initialize(audioSource);
            soundOut.Play();
            
        }

        public void Play()
        {
            soundOut.Play();
        }

        public void Pause()
        {
            soundOut.Pause();
        }
    }
}
