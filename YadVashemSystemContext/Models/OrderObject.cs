using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YadVashemOrdersContext.Models
{
    [Serializable]
    public class OrderObject
    {
        public string StartTime { get; set; }
        public int AvailablePlaces { get; set; }
        public bool IsClosed { get; set; }
     
    }

}
