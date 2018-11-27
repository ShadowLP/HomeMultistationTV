using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Domain.Entity
{
    public class LocationDto : EntityDto
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public String Name { get; set; }

    }
}
