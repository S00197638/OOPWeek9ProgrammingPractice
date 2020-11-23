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

    public enum Genre { Rock, Pop, Dance, Other }

    public class Song
    {
        #region Properties

        public string Title { get; set; }

        public string Artist { get; set; }

        public double Duration { get; set; }

        public Genre MusicGenre { get; set; }

        #endregion

        #region Constructors

        public Song(string title, string artist, double duration, Genre musicGenre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            MusicGenre = musicGenre;
        }

        public Song(string title, string artist) : this(title, artist, 0, Genre.Other) { }

        public Song() : this("Unknown", "Unknown") { }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format($"{Title} {Artist} {Duration} {MusicGenre}");
        }

        #endregion

    }//End of Song Class
}
