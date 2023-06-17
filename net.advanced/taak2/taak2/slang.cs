using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace taak2
{
    internal class slang : dier
    {
        public SoundPlayer SlangsoundPlayer;
        public slang(int gewicht) : base(gewicht)
        {
        }

        public string sssss()
        {
            SlangsoundPlayer = new SoundPlayer(@"C:\Users\Soufian\Documents\ehb\net.advanced\taak2\taak2\obj\snake.wav");
            SlangsoundPlayer.Play();
            return base.Zegt("sssss");
        }

        public override string? ToString()
        {
            return sssss();
        }
    }
}
