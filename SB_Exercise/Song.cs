using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_Exercise
{
    public class Song
    {
        private List<String> song;

        public Song(String[] song)
        {
            this.song = new List<String>(song);
        }

        public List<String> getSong()
        {
            return this.song;
        }

        public Song searchSound(String sound)
        {
            String[] values;
            Song remainingSounds = null;

            if (sound.Equals("croac") || sound.Equals("brrah"))
            {
                return remainingSounds;
            }

            if (this.song.Contains(sound))
            {
                values = getRemainingSounds(this.song.IndexOf(sound));

                if (values != null)
                    remainingSounds = new Song(values);
            }

            return remainingSounds;
        }

        public String[] getRemainingSounds(int index)
        {
            int j = 0;
            string[] remainingSounds = null;
            remainingSounds = new String[this.song.Count - 1 - index];                        

            for (int i = index + 1; i < this.song.Count; i++)
            {
                remainingSounds[j++] = this.song[i];                
            }

            return remainingSounds;
        }
    }
}
