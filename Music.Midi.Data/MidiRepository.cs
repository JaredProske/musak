using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Music.Midi.Data
{

    public static class MidiRepository
    {
        public static Stream GetMidiFile()
        {
             var assembly = Assembly.GetExecutingAssembly();
           return  assembly.GetManifestResourceStream("Music.Midi.Data.BachInventions.BachInvention01.mid");

        }
    }
}
