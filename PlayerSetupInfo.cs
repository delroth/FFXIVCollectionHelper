using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFXIVCollectHelper
{
    /// <summary>
    /// Utilities to manipulate PlayerSetup FFXIV protocol messages.
    /// </summary>
    class PlayerSetupInfo
    {
        public string PlayerName { get; set;  }
        public List<uint> AcquiredMounts { get; set;  }
        public List<uint> AcquiredBardings { get; set; }
        public List<uint> AcquiredOrchestrions { get; set; }

        // Last update: 5.0 (2019-07-13).
        private const ushort PLAYERSETUP_OPCODE = 0x18F;
        private const uint PLAYERSETUP_EXPECTED_LENGTH = 2112;
        private const uint PLAYER_NAME_OFFSET = 0x25B;
        private const uint PLAYER_NAME_LENGTH = 32;
        private const uint MOUNTS_OFFSET = 0x246;
        private const uint MOUNTS_LENGTH = 21;
        private const uint BARDINGS_OFFSET = 0x573;
        private const uint BARDINGS_LENGTH = 10;
        private const uint ORCHESTRIONS_OFFSET = 0x756;
        private const uint ORCHESTRIONS_LENGTH = 42;

        /// <summary>
        /// Attempts to parse a PlayerSetup packet and returns its information if valid, null if invalid.
        /// </summary>
        public static PlayerSetupInfo ParseOrNull(byte[] data)
        {
            if (data.Length != PLAYERSETUP_EXPECTED_LENGTH)
                return null;

            var opcode = BitConverter.ToUInt16(data, 0x12);
            if (opcode != PLAYERSETUP_OPCODE)
                return null;

           return new PlayerSetupInfo
            {
                PlayerName = ReadStringAt(data, PLAYER_NAME_OFFSET, PLAYER_NAME_LENGTH),
                AcquiredMounts = ReadBitmaskAt(data, MOUNTS_OFFSET, MOUNTS_LENGTH),
                AcquiredBardings = ReadBitmaskAt(data, BARDINGS_OFFSET, BARDINGS_LENGTH),
                AcquiredOrchestrions = ReadBitmaskAt(data, ORCHESTRIONS_OFFSET, ORCHESTRIONS_LENGTH),
            };
        }

        private static string ReadStringAt(byte[] data, uint offset, uint length)
        {
            var s = Encoding.ASCII.GetString(data, (int)offset, (int)length);
            return s.Replace("\0", string.Empty);
        }
        private static List<uint> ReadBitmaskAt(byte[] data, uint offset, uint length)
        {
            var li = new List<uint>();
            for (uint i = 0; i < length; ++i)
            {
                byte b = data[offset + i];
                for (uint j = 0; j < 8; ++j)
                {
                    if ((b & 1) == 1)
                    {
                        li.Add(i * 8 + j);
                    }
                    b >>= 1;
                }
            }
            return li;
        }

        /// <summary>
        /// Use the ParseOrNull factory method instead.
        /// </summary>
        private PlayerSetupInfo() { }
    }
}
