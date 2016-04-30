using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireWPF
{
    class MyRandom
    {
        int g_seed;

        public MyRandom(int seed)
        {
            g_seed = seed;
        }

        public int Next()
        {
            g_seed = (214013 * g_seed + 2531011);
            return (g_seed >> 16) & 0x7FFF;
        }

        public int Next(int max)
        {
            g_seed = (214013 * g_seed + 2531011);
            int z = (g_seed >> 16) & 0x7FFF;
            if (z < 0)
                z += int.MaxValue;

            return z % max;
        }
    }
}
