using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using YourMusicDatabase.Models.Song;

namespace YourMusicDatabase.Models.Album
{
    public class AlbumModel
    {

        public int AlbumId { get; set; }

        [DisplayName("Title")]
        public string AlbumTitle { get; set; }


        [DisplayName("Artist")]
        public string AlbumArtist { get; set; }

        [DisplayName("Release Date")]
        public DateTime AlbumReleaseDate { get; set; }

        //figure how to store a picture 

        [DisplayName("Track List")]
        public List<SongModel> AlbumTrackList { get; set; }
    }
}