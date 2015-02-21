﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascii_Animator
{
    static class SaveBat
    {
        public static string echo = @"@echo off";
        
        public static void save()
        {
            //TODO
        }
        public static string construct(Animation animation)
        {
            int fps = 1000 / animation.fps;
            string script = "@echo off";
            for (int i = 0; i < animation.frames.Length; i++)
            {
                script += "\necho " + animation.frames[i] + "\nping -n 1 -w " + fps + " 10.0.0.193 > nul 2>&1\ncls";
            }

            Console.WriteLine(script);
            return (script);
        }
    }
}
