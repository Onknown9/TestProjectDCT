using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestProjectDCT
{
    public class Root
    {
        [JsonPropertyName("data")]
        public List<Data> Data { get; set; }
    }
}
