using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Models;

namespace CarsScenarios.CarsDomain.Queries
{
    public class GetCarsHandler : IRequestHandler<GetCarsRequest, IEnumerable<Car>>
    {
        public GetCarsHandler()
        {
            
        }

        public async Task<IEnumerable<Car>> Handle(GetCarsRequest request, CancellationToken cancellationToken)
        {
            var cars = new List<Car>()
            {
                new Car
                {
                    PlateNo = "WT2810", Make = "Nissam", Model = "Tida", Seats = 5, FuelType = FuelType.Petrol,
                    Transmission = TransmissionType.Automatic, Odometer = 32000
                },
                new Car
                {
                    PlateNo = "JGQ290", Make = "Honda", Model = "HR-V", Seats = 5, FuelType = FuelType.Petrol,
                    Transmission = TransmissionType.Manual, Odometer = 70000
                },
                new Car
                {
                    PlateNo = "LDZ240", Make = "Nissam", Model = "Tida", Seats = 5, FuelType = FuelType.Petrol,
                    Transmission = TransmissionType.Automatic, Odometer = 32000
                },
                new Car
                {
                    PlateNo = "LYE801", Make = "Honda", Model = "HR-V", Seats = 5, FuelType = FuelType.Petrol,
                    Transmission = TransmissionType.Manual, Odometer = 70000
                }
            };

            await Task.Delay(500, cancellationToken).ConfigureAwait(false);

            return request.PlateNo == null ? cars : cars.FindAll(x => x.PlateNo.ToLower() == request.PlateNo.ToLower()).ToList();
        }
    }
}
