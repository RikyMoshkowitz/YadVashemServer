using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YadVashemSystemContext.ModelsDto
{
    public class OrderObjectDto
    {
      
            public string StartTime { get; set; }
            public int AvailablePlaces { get; set; }
            public bool IsClosed { get; set; }
            public string Condition { get; set; }
        
    }
}
