using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinqtoEntites.Models.Entities
{
    public class RouteInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }

        public virtual ICollection<Transport> Transports { get; set; }
        public virtual ICollection<StopInfo> Stops { get; set; }
    }
}
