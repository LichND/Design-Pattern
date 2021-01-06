using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class RandomPlus
    {
        private static double get()
        {
            RandomNumberGenerator i = RandomNumberGenerator.Create();
            byte[] data = new byte[8];
            i.GetBytes(data);
            long t = 0;
            foreach (var item in data)
                t = (t << 8) | item;
            t &= long.MaxValue;
            return (double)t / long.MaxValue;
        }
        /// <summary>
        /// Return random number between 0 (include) and 1 (exclude)
        /// </summary>
        public static float getValue() => (float)get();
        /// <summary>
        /// Return random number between lower (include) and upper (exclude)
        /// </summary>
        public static float getRange(float lower, float upper) => (float)get() * (upper - lower) + lower;
        /// <summary>
        /// Return random number between lower (include) and upper (exclude)
        /// </summary>
        public static int getRange(int lower, int upper) => (int)Math.Floor(get() * (upper - lower) + lower);
    }
}
