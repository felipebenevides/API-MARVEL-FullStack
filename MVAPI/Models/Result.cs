using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MVAPI.Models
{
    [DataContract]
    public class Result
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string description { get; set; }
        //[DataMember]
        //public DateTime modified { get; set; } 
        [DataMember]
        public string modified { get; set; }
        [DataMember]
        public Thumbnail thumbnail { get; set; }
        [DataMember]
        public string resourceURI { get; set; }
        [DataMember]
        public Comics comics { get; set; }
        [DataMember]
        public Series series { get; set; }
        [DataMember]
        public Stories stories { get; set; }
        [DataMember]
        public Events events { get; set; }
        [DataMember]
        public List<Url> urls { get; set; }

        public string UrlWiki { get; set; }
    }
}
