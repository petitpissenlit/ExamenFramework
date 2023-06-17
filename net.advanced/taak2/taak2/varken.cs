using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace taak2
{
    internal class varken : dier
    {
        public SoundPlayer VarkensoundPlayer;
        public varken(int gewicht) : base(gewicht)
        {
        }
        public string Ooeink()
        {
            VarkensoundPlayer = new SoundPlayer(@"C:\Users\Soufian\Documents\ehb\net.advanced\taak2\taak2\obj\pigg.wav");
            VarkensoundPlayer.Play();
            return base.Zegt("groinnk");
        }

        public override string? ToString()
        {
            return Ooeink();
        }
    }
}
