using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MVAPI.Application.ViewModels
{
    public class ResultViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string modified { get; set; }
        public ThumbnailViewModel thumbnail { get; set; }
        public string resourceURI { get; set; }
        public ComicsViewModels comics { get; set; }
        public SeriesViewModel series { get; set; }
        public StoriesViewModel stories { get; set; }
        public EventsViewModel events { get; set; }
        public List<UrlViewModel> urls { get; set; }

        public string UrlWiki { get; set; }
    }
}
