using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascii_Animator
{
    [Serializable]
    public class Animation
    {
        public int fps;
        public string[] frames;

        public void InitAnimation(int FPS, string[] Frames)
        {
            fps = FPS;
            frames = Frames;
        }
    }
}
