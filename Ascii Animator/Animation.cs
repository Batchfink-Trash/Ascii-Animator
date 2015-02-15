using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascii_Animator
{
    class Animation
    {
        public int fps;
        public string[] frames;

        public Animation(int FPS, String[] Frames)
        {
            fps = FPS;
            frames = Frames;
        }

    }
}
