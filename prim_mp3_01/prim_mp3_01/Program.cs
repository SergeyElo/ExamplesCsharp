using System;
using System.Windows.Media;

namespace prim_mp3_01
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaPlayer player = new MediaPlayer();
            player.Open(new Uri("C:\\Kalimba.mp3", UriKind.Absolute));
            player.Play();
            Console.ReadKey();
        }
    }
}
