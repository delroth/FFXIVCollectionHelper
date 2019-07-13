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
    struct PlayerSetupInfo
    {
        // Last update: 5.0 (2019-07-13).
        private const ushort PLAYERSETUP_OPCODE = 0x18F;
        private const uint PLAYERSETUP_EXPECTED_LENGTH = 2112;

        /// <summary>
        /// Attempts to parse a PlayerSetup packet and returns its information if valid, null if invalid.
        /// </summary>
        public static PlayerSetupInfo? ParseOrNull(byte[] data)
        {
            if (data.Length != PLAYERSETUP_EXPECTED_LENGTH)
                return null;

            var opcode = BitConverter.ToUInt16(data, 0x12);
            if (opcode != PLAYERSETUP_OPCODE)
                return null;

            PlayerSetupInfo info = new PlayerSetupInfo();
            return info;
        }
    }
}
