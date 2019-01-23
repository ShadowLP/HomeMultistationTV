using System;

namespace Weather.Communication.Entity
{
    public class LocationDto : EntityDto
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public String Name { get; set; }

    }
}
