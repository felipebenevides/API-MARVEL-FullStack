using MVAPI.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MVAPI.Application.ViewModels
{
    public class ComicsViewModels
    {
        public int available { get; set; }
        public string collectionURI { get; set; }
        public List<ComicSummaryViewModel> items { get; set; }
        public int returned { get; set; }
    }
}
