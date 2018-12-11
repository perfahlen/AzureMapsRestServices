using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Timezone
{
    public class ReferenceTime
    {
        /// <summary>
        /// Daylight Savings property
        /// </summary>
        public string DaylightSavings { get; set; }


        /// <summary>
        /// Posix timezone property
        /// </summary>
        public string PosixTimezone { get; set; }

        /// <summary>
        /// Posix Timezone Valid Year property
        /// </summary>
        public int PosixTimezoneValidYear { get; set; }


        /// <summary>
        /// Standard Offset property
        /// </summary>
        public string StandardOffset { get; set; }

        /// <summary>
        /// Tag property
        /// </summary>
        public string Tag { get; set; }


        /// <summary>
        /// Wall Time property
        /// </summary>
        public string WallTime { get; set; }
    }
}
