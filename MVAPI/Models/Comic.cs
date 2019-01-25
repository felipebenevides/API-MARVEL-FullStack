using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MVAPI.Models
{
    [DataContract]
    public class Comics
    {
        [DataMember]
        public int available { get; set; }
        [DataMember]
        public string collectionURI { get; set; }
        [DataMember]
        public List<ComicSummary> items { get; set; }
        [DataMember]
        public int returned { get; set; }
    }
}
