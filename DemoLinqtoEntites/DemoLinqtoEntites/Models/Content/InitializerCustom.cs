using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLinqtoEntites.Models.Content;
using System.Data.Entity;
using DemoLinqtoEntites.Models.Entities;

namespace DemoLinqtoEntites.Models.Content
{
    public class InitializerCustom : CreateDatabaseIfNotExists<TransportContext>
    {
        protected override void Seed(TransportContext context)
        {
            base.Seed(context);

            Transport transport1 = new Transport() { Name = "AutoBus"};
            Transport transport2 = new Transport() { Name = "TrolleyBus"};
            Transport transport3 = new Transport() { Name = "Tram" };
            Transport transport4 = new Transport() { Name = "AutoBus"};
            Transport transport5 = new Transport() { Name = "TrolleyBus"};
            Transport transport6 = new Transport() { Name = "Tram"};

            StopInfo stop1 = new StopInfo() { Name = "ДС Веснянка" };
            StopInfo stop2 = new StopInfo() { Name = "Кавальская слобода" };
            StopInfo stop3 = new StopInfo() { Name = "Гостиница Юбилейная" };
            StopInfo stop4 = new StopInfo() { Name = "Магазин Спутник" };
            StopInfo stop5 = new StopInfo() { Name = "Вокзал" };
            StopInfo stop6 = new StopInfo() { Name = "ДС Дружная" };
            StopInfo stop7 = new StopInfo() { Name = "Брилевичи" };

            

            RouteInfo route1 = new RouteInfo() { Name = "ДС Веснянка - Вокзал", Number = "Маршрут 1" };
            route1.Transports = new List<Transport> { transport1, transport2, transport3 };
            

            RouteInfo route2 = new RouteInfo() { Name = "ДС Дружная - Брилевичи", Number = "Маршрут 2"};
            route2.Transports = new List<Transport> { transport4, transport5, transport6 };


            RoadtoStop roadtostop1 = new RoadtoStop() { Routes = route1, Stops = stop1, VisitTime = new DateTime(2008, 5, 1, 8, 30, 52) };

            context.Routes.AddRange(new[] { route1, route2 });
            context.SaveChanges();

        }
    }
}
