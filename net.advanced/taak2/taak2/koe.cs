using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace taak2
{
    internal class koe : dier
    {
        public SoundPlayer KoesoundPlayer;

        public koe(int gewicht) : base(gewicht)
        {
        }

        public string boeet()
        {
            KoesoundPlayer = new SoundPlayer(@"C:\Users\Soufian\Documents\ehb\net.advanced\taak2\taak2\obj\meuh.wav");
            KoesoundPlayer.Play();
            return base.Zegt("boeet");
        }

        public override string? ToString()
        {
            return boeet();
        }

    }
}
