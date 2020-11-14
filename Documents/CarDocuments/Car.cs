using Models;

namespace Documents.CarDocuments
{
    public class Car
    {
        public string PlateNo { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Seats { get; set; }
        public FuelType FuelType { get; set; }
        public TransmissionType Transmission { get; set; }
        public int Odometer { get; set; }
    }
}
