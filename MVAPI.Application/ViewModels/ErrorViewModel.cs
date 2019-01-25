using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVAPI.Models
{
    public class ErrorViewModel
    {
        public string RequestID { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestID);
    }
}
