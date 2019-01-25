using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVAPI.Application
{
    public class PersonagensViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime modified { get; set; }
        public List<string> thumbnail { get; set; }
        public string resourceURI { get; set; }
        public List<string> comics { get; set; }
        public List<string> series { get; set; }
        public List<string> stories { get; set; }
        public List<string> events { get; set; }
        public List<string> urls { get; set; }
        public string UrlWiki { get; set; }
    }
}
