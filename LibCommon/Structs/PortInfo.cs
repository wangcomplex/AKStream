using System;

namespace LibCommon.Structs
{
    [Serializable]
    public class PortInfo
    {
        private ushort _port;
        private DateTime _dateTime;
        private bool _useed;

        public ushort Port
        {
            get => _port;
            set => _port = value;
        }

        public DateTime DateTime
        {
            get => _dateTime;
            set => _dateTime = value;
        }

        public bool Useed
        {
            get => _useed;
            set => _useed = value;
        }
    }
}