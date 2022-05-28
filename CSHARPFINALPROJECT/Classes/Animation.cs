using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Resources;
using CSHARPFINALPROJECT.Properties;
using System.Media;

namespace ProjectFinal.Classes
{
    public abstract class Animation
    {
        public static void Intro()
        {
            SoundPlayer soundPlayer = new SoundPlayer(Resources.bossaz_intorsound);
            soundPlayer.Play();
            Console.Clear();
            string brand = "BOSS.AZ";
            string slogan = "Ishin Tek Adresi";
            Thread.Sleep(450);
            GoToLocation(FindCenterText(59, brand.Length), 15);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Write(brand, 100);
            GoToLocation(FindCenterText(59, slogan.Length), 16);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Write(slogan, 100);
            Console.ResetColor();
        }

        static public void Write(string txt, int delay)
        {
            foreach (char sym in txt)
            {
                Console.Write(sym);
                Thread.Sleep(delay);
            }
        }

        static public void GoToLocation(int space, int line)
        {
            Console.SetCursorPosition(space, line);
        }
        static public int FindCenterText(int space, int txtLen) =>
           txtLen <= (118 - space) ? space - (txtLen / 2) : (int)118 - txtLen;
    }
}