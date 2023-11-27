using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project
{
    public class _PacketType
    {
        private int _R;
        public int R
        {
            get => _R;
            set => _R = CheckValue(value);
        }

        private int _G;
        public int G
        {
            get => _G;
            set => _G = CheckValue(value);
        }

        private int _B;
        public int B
        {
            get => _B;
            set => _B = CheckValue(value);
        }

        public _PacketType(int R,
                          int G,
                          int B)
        {
            this.R = R;
            this.G = G;
            this.B = B;
        }

        public _PacketType(float R,
                          float G,
                          float B)
        {
            this.R = (int)R;
            this.G = (int)G;
            this.B = (int)B;
        }

        private int CheckValue(int value)
        {
            if (value > 255)
            {
                return 255;
            }
            else if (value < 0)
            {
                return 0;
            }
            else
            {
                return value;
            }
        }
    }


    public class CoordinatesType
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float Size { get; set; } = 1;

        public _PacketType packet { get; set; }

        public CoordinatesType(float X,
                          float Y,
                          float Z,
                          _PacketType packet)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;

            this.packet = packet;
        }

        public CoordinatesType(float X,
                          float Y,
                          float Z,
                          float Size,
                          _PacketType packet)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            this.Size = Size;

            this.packet = packet;
        }

    }
}
