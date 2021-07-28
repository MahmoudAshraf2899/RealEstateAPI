using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Classes
{
    public class DublexQueryParameters : QueryParameters
    {
        public string Payment { get; set; }
        public string Address { get; set; }
        public string Informations { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }        
        public string SearchTerm { get; set; }
    }
}
