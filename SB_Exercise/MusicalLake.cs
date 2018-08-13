using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_Exercise
{
    public class MusicalLake
    {
        private Song song1 = new Song(new String[] { "brr", "fiu", "cric-cric", "brrah" });
        private Song song2 = new Song(new String[] { "pep", "birip", "trri-trri", "croac" });
        private Song song3 = new Song(new String[] { "bri-bri", "plop", "cric-cric", "brrah" });

        public Song searchSound(String sound)
        {
            Song value = song1.searchSound(sound);

            if (value != null)
            {
                return value;
            }

            value = song2.searchSound(sound);

            if (value != null)
            {
                return value;
            }

            value = song3.searchSound(sound);

            if (value != null)
            {
                return value;
            }

            return value;
        }

    }
}
