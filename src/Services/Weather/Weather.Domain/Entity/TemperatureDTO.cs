using System;
using System.Collections.Generic;
using System.Text;
using Weather.Domain.Enums;

namespace Weather.Domain.Entity
{
    public class TemperatureDto : EntityDto
    {
        public double Value { get; set; }

        public string Comment { get; set; }

        public ETemperatureScale Scale { get; set; }
    }
}
