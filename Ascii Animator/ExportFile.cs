using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Ascii_Animator
{
    static class ExportFile
    {
        public static string echo = @"@echo off";
        
        public static string save(Animation a)
        {
            // Save the animation class as an xml file
            // this seialises the object, uses a StringWriter to build a string and returns it.
            XmlSerializer x = new XmlSerializer(a.GetType());
            using (StringWriter textWriter = new StringWriter())
            {
                x.Serialize(textWriter, a);
                return textWriter.ToString();
            }
        }//Serialize animation object

        public static Animation open(string path)
        {
            Animation a = new Animation();
            XmlSerializer x = new XmlSerializer(typeof(Animation));
            StreamReader reader = new StreamReader(path);

            a = (Animation)x.Deserialize(reader);

            return a;
        }

        public static string constructBat(Animation animation)
        {
            int fps = 1000 / animation.fps;
            string script = "@echo off";
            for (int i = 0; i < animation.frames.Length; i++)
            {
                script += "\necho " + animation.frames[i] + "\nping -n 1 -w " + fps + " 10.0.0.193 > nul 2>&1\ncls";
            }

            Console.WriteLine(script);
            return (script);
        }//construct .bat file

        public static string constructPy(Animation animation)
        {
            double fps = 1.0 / Convert.ToDouble(animation.fps);
            string script = "from time import sleep\nfrom os import system\n";
            for (int i = 0; i < animation.frames.Length; i++)
            {
                script += "\nprint(\"" + animation.frames[i] + "\")\nsleep(" + fps + ")\nsystem(\"cls\")";
            }
            Console.WriteLine(script);
            return (script);
        }//construct .py file
    }
}
