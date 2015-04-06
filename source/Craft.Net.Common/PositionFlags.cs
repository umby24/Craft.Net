namespace Craft.Net.Common
{
    /// <summary>
    /// Structure for the bit field used in the player position and look packet.
    /// </summary>
    public struct PositionFlags {
        public bool X, Y, Z, YRot, XRot;

        public void Unpack(byte value) {
            X = (value & 0x01) > 0;
            Y = (value & 0x02) > 0; 
            Z = (value & 0x04) > 0; 
            YRot = (value & 0x08) > 0; 
            XRot = (value & 0x10) > 0; 
        }

        public byte Pack() {
            byte value = 0;

            value |= (byte)(X ? 0x01 : 0);
            value |= (byte)(Y ? 0x02 : 0);
            value |= (byte)(Z ? 0x04 : 0);
            value |= (byte)(YRot ? 0x08 : 0);
            value |= (byte)(XRot ? 0x10 : 0);

            return value;
        }
    }
}
