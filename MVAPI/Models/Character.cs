using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MVAPI.Models
{
    [DataContract]
    public class Character
    {
        #region Properties
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string description { get; set; }

        [DataMember]
        public string modified { get; set; }

        [DataMember]
        public string resourceURI { get; set; }

        [DataMember]
        public List<Url> urls { get; set; }

        [DataMember]
        public Thumbnail thumbnail { get; set; }

        [DataMember]
        public List<Comics> comics { get; set; }

        [DataMember]
        public List<Stories> stories { get; set; }


        [DataMember]
        public List<Series> series { get; set; }
        #endregion

        //public int Id { get; set; }
        //public string Nome { get; set; }
        //public string Descricao { get; set; }
        //public string UrlImagem { get; set; }
        //public string UrlWiki { get; set; }

        //[DataMember]
        //public Comic[] ComicList { get; set; }
        //public Comic[] ComicList { get; set; }

        //public string  name { get; set; }
        //public string description  { get; set; }
        //public DateTime modified { get; set; }
        //public string resourceURl { get; set; }
        //public string [] urls { get; set; }
    }
}
