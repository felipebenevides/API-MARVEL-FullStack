using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVAPI.Models
{
    public class Series
    {
        public int available { get; set; }
        public string collectionURI { get; set; }
        public Item1[] items { get; set; }
        public int returned { get; set; }
    }
}
