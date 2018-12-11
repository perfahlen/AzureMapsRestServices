using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Timezone
{
    public class TimeZoneRequest : RequestBase
    {
        public TimezoneOptions Options { get; set; }


        public string TimeStamp { get; set; }


        public string TransitionsFrom { get; set; }

        public int? TransitionsYears { get; set; }

        public string Query { get; set; }


    }
}
