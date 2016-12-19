using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NAudioWpfDemo.DMX
{
    public class VerwerkData
    {
        static DMX dmx = new DMX();
        public static int patternCode;
        public static int groupCode;
        static int i = 0; static int x = 0; const int IT = 300;
        static List<double> dicVolumes = new List<double>();
        static double avVolume = 0;
        static bool manual;
        static int bass;
        static int zoomSpeed;
        const int BASSTIME = 15;
        static int bassTime = BASSTIME;

        internal static void VerwerkFreqs(Dictionary<int, double> freqs)
        {
            bass = Convert.ToInt32((1 - freqs[0]) * 127);

            if (bass < 70)
            {
                bass = 0;
                zoomSpeed = 5;
                bassTime = 0;
            }
            if (bass > 100)
            {
                bass = Math.Min(115, bass);
                bassTime++;
                if (bassTime > BASSTIME)
                {
                    bass = 255;
                    zoomSpeed = 100;
                }
            }

            Console.WriteLine(bass);

            foreach (KeyValuePair<int, double> freq in freqs)
            {
                dicVolumes.Add(freq.Value);
            }

            if (i == 5)
            {
                avVolume = 0;
                foreach (double freq in dicVolumes)
                {
                    avVolume += freq;
                }

                avVolume = avVolume / dicVolumes.Count;
                avVolume = (avVolume * 900) + 8;
                avVolume = Math.Min(avVolume, 56);
                if (avVolume == 56)
                    avVolume = 255;
                i = -1;
                dicVolumes.Clear();

            }

            if (!manual && x == IT)
            { 
                groupCode = new Random().Next(5);
                if(groupCode == 4) patternCode = new Random().Next(15);
                else patternCode = new Random().Next(16);
                x = 0;
            }

            int pattern = patternCode * 16;
            int group = groupCode * 52;

            byte[] buffer = new byte[dmx.DMX_DATA_LENGTH];
            buffer[0] = (byte)255;
            buffer[1] = (byte)255;
            buffer[2] = (byte)group;
            buffer[3] = (byte)pattern;
            buffer[4] = (byte)Convert.ToInt32(avVolume);
            buffer[5] = (byte)0;
            buffer[6] = (byte)bass;
            buffer[7] = (byte)zoomSpeed;
            buffer[8] = (byte)128;
            buffer[9] = (byte)100;
            dmx.FTDISendData(dmx.SET_DMX_TX_MODE, buffer, dmx.DMX_DATA_LENGTH);
            i++;
            x++;
        }
    }
}
