using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First
{
    
    class Broker
    {
       
        public int BrokerId { get; set; }
        public string BrokerCode { get; set; }
        public string BrokerName { get; set; }
    }
}
