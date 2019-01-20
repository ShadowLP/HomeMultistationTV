using Weather.Domain.Enums;

namespace Weather.Communication.Entity
{
    public class TemperatureDto : EntityDto
    {
        public double Value { get; set; }

        public string Comment { get; set; }

        public ETemperatureScale Scale { get; set; }
    }
}
