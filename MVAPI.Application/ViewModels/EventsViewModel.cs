using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVAPI.Application.ViewModels
{
    public class EventsViewModel
    {
        public int available { get; set; }
        public string collectionURI { get; set; }
        public Item3ViewModel[] items { get; set; }
        public int returned { get; set; }
    }
}
