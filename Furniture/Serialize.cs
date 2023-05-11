using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Furniture
{
    internal class Serialize
    {
        StreamWriter sw = new StreamWriter("C:\\Users\\Арсений\\source\\repos\\Furniture-auto-placement-app\\Json.json");
        string json;
        IPolygon? restoredPerson;
        public void polygonSerialize(IPolygon polygon)
        {
            json = JsonSerializer.Serialize(polygon);
            sw.WriteLine(json);
            sw.Close();
        }

        public void polygonDeserialize()
        {
            restoredPerson = JsonSerializer.Deserialize<IPolygon>(json);
        }
    }
}
