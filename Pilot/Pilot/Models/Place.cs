using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
 
namespace Pilot.Models
{
    public class ALL
    {
        [JsonProperty("hour")]
        public int hour { get; set; }
        [JsonProperty("minute")]
        public int minute { get; set; }
        [JsonProperty("hourE")]
        public int hourE { get; set; }
        [JsonProperty("minuteE")]
        public int minuteE { get; set; }
        [JsonProperty("trybZegar")]
        public int trybZegar { get; set; }
        [JsonProperty("tryb")]
        public int tryb { get; set; }
        [JsonProperty("wifi")]
        public int wifi { get; set; }
    }


}
