namespace Weather.Domain.Entity
{
    public class WeaterDto : EntityDto
    {
        public LocationDto Location { get; set; }

        public double Temperature { get; set; }
    }
}
