using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.models
{
    public class VideoPlayer : MediaPlayer
    {
        public VideoPlayer(string filename) : base(filename){}
        public override void Play()
        {
            Console.WriteLine($"Playing video: {FileName}");
        }
        public override void Pause()
        {
            Console.WriteLine($"Pausing video: {FileName}");
        }
        public override void Stop()
        {
            Console.WriteLine($"Stopping video: {FileName}");
        }
    }
}