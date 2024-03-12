using HotChocolate.Types;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shared
{
    [QueryType]
    public class VehicleQuery
    {
        public IEnumerable<Vehicle> GetVehicles(Vehicle vehicle)
        {
            return new Vehicle[] { new Vehicle() { pk = 1, description = "TEST", name = "Test Vehicle", vin = "ABC1234567890", lessee_code = "01AB" } };
        }
    }
}