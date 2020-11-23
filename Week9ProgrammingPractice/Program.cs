using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9ProgrammingPractice
{
    /*##########################################################################################################################
     * 
     * Week9ProgrammingPractice
     * Started : 23/11/2020
     * Last Edited : 23/11/2020
     * Jake Beecham
     * S00197638
     * 
    ###########################################################################################################################*/

    class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("BEAUTIFUL PEOPLE", "ED SHEERAN", 3.15, Genre.Pop);
            Song song2 = new Song("RIDE IT", "REGARD", 3.37, Genre.Dance);
            Song song3 = new Song("DANCE MONKEY", "TONES & I", 4.20, Genre.Dance);
            Song song4 = new Song("CIRCLES", "POST MALONE", 3.25, Genre.Pop);
            Song song5 = new Song("SOUTH OF THE BORDER", "ED SHEERAN", 4.26, Genre.Other);

            List<Song> playlist = new List<Song>();

            playlist.Add(song1);
            playlist.Add(song2);
            playlist.Add(song3);
            playlist.Add(song4);
            playlist.Add(song5);

            Console.WriteLine("You Have Created A New Playlist!");
            DisplayPlaylist(playlist);

            Console.ReadLine();

        }//End of Main Method

        private static void DisplayPlaylist(List<Song> playlist)
        {
            Console.WriteLine("\n{0, -18}{1, -28}{2, -15}{3, -15}", "Artist", "Song", "Duration", "Genre");
            
            foreach (Song song in playlist)
            {
                Console.WriteLine(song);
            }

        }//End of DisplayPlaylist Method

    }//End of Program Class
}
