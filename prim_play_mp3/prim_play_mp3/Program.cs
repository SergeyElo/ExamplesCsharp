using System;
using System.Windows.Media;

namespace prim_play_mp3
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaPlayer player = new MediaPlayer();
            player.Open(new Uri("C:\\sound.mp3", UriKind.Absolute));
            player.Play();
            Console.ReadKey();

        }
    }
}



 
