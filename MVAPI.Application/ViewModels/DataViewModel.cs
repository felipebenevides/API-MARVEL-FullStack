using MVAPI.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MVAPI.Application.ViewModels
{
    public class DataViewModel
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public int count { get; set; }
        public List<ResultViewModel> results { get; set; }
        public ResultViewModel ResultadoPersonagem { get; set; }

    }
}
