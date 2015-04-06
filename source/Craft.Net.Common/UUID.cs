using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Craft.Net.Common
{
    public struct UUID {
        public byte[] Id;

        public UUID(byte[] value) {
            if (value.Length != 16)
                throw new InvalidOperationException("Cannot create a uuid from more or less than 128-bits");
        }
        public byte GetVersion() {
            return Id[6];
        }

        public string ToString() {
            // -- 4 - 2 - 2 - 8

        }
    }
}
