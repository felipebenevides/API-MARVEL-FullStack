using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MVAPI.Models
{
    [DataContract]
    public class Data
    {
        [DataMember]
        public int offset { get; set; }
        [DataMember]
        public int limit { get; set; }
        [DataMember]
        public int total { get; set; }
        [DataMember]
        public int count { get; set; }
        [DataMember]
        public List<Result> results { get; set; }

        public Result ResultadoPersonagem { get; set; }

    }
}
