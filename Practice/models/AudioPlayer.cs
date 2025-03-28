using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.models
{
    public class AudioPlayer : MediaPlayer
    {
        public AudioPlayer(string fileName) : base(fileName){}
        public override void Play()
        {
            Console.WriteLine($"Playing audio file: {FileName}");
        }
        public override void Pause()
        {
            Console.WriteLine($"Pausing audio file: {FileName}");
        }
        public override void Stop()
        {
            Console.WriteLine($"Stopping audio file: {FileName}");
        }
    }
}