using Graph.ArgumentValidator;
using System.ComponentModel.DataAnnotations;

namespace Shared
{
    [Validatable]
    public class Vehicle
    {
        public int pk { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string vin { get; set; }

        [MinLength(4)]
        public string lessee_code { get; set; }

        public Vehicle()
        { }
    }
}