using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVAPI.Models
{
    public class Events
    {
        public int available { get; set; }
        public string collectionURI { get; set; }
        public Item3[] items { get; set; }
        public int returned { get; set; }
    }
}
