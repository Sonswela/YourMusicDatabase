using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace YourMusicDatabase.Models.Song
{
    public class SongModel
    {

        public int SongId { get; set; }

        public int AlbumId { get; set; }

        [DisplayName("Song Title")]
        public string SongTitle { get; set; }

        [DisplayName("Artist")]
        public string SongArtist { get; set; }

        [DisplayName("ReleaseDate")]
        public DateTime SongReleaseDate { get; set; }

        [DisplayName("Lyrics")]
        public string SongLyircs { get; set; }
        
        [DisplayName("Single?")]
        public bool SingleBool { get; set; }
    }
}