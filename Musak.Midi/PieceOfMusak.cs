using System.Collections.Generic;

namespace Musak.Midi
{
    public class PieceOfMusak
    {
        public PieceOfMusak()
        {
            TrackList = new List<MusakTrack>();
            MetaData = new MusakMetaData();
        }
        public List<MusakTrack >TrackList{ get; set; }
        public MusakMetaData MetaData { get; set; }
    }
}