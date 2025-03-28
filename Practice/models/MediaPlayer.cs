using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.models
{
    public abstract class MediaPlayer 
    {
        public string FileName { get; set; }
        public abstract void Play();
        public abstract void Pause();
        public abstract void Stop();

        public MediaPlayer(string fileName) 
        {
            FileName = fileName;
            Console.WriteLine($"{fileName} is loaded.");
        }
    }
}