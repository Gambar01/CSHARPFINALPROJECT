using ProjectFinal.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Media;
using System.Threading.Tasks;
using CSHARPFINALPROJECT.Properties;

namespace ProjectFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer(Resources.The_Pink_Panther_Theme_Music);
            Animation.Intro();
            Thread.Sleep(1000);
            player.PlayLooping();
            Run.Runn();
        }
    }
}
