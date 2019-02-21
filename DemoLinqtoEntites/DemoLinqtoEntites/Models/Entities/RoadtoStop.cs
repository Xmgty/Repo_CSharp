using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinqtoEntites.Models.Entities
{
    public class RoadtoStop
    {
        public int Id { get; set; }

        public virtual RouteInfo Routes { get; set; }

        public virtual StopInfo Stops { get; set; }

        public DateTime VisitTime { get; set; }


    }
}
