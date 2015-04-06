using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Craft.Net.Common
{
    public struct Position 
    {
        public int X;
        public short Y;
        public int Z;

        public ulong ToLong() {
            return (ulong)(((X & 0x3FFFFFFF) << 38) | ((Y & 0xFFF) << 26) | (Z & 0x3FFFFFFF));
        }

        public Position FromLong(ulong value) {
            X = (int) (value >> 38);
            Y = (short) ((value >> 26) & 0xFFF);
            Z = (int) (value << 38 >> 38);

            return this;
        }
    }
}
