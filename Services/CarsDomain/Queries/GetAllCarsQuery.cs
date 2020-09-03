using MediatR;
using Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceDomains.CarsDomain.Queries
{
    public class GetAllCarsQuery : IRequest<IEnumerable<Car>> { }

    public class GetAllCarsQueryHandler : IRequestHandler<GetAllCarsQuery, IEnumerable<Car>>
    {
        public GetAllCarsQueryHandler()
        {
            
        }

        public async Task<IEnumerable<Car>> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
        {
            return new[]
            {
                new Car { PlateNo = "WT2810", Make = "Nissam", Model = "Tida", Seats = 5, FuelType = FuelType.Petrol, Transmission = TransmissionType.Automatic, Odometer = 32000 },
                new Car { PlateNo = "JGQ290", Make = "Honda", Model = "HR-V", Seats = 5, FuelType = FuelType.Petrol, Transmission = TransmissionType.Manual, Odometer = 70000 }
            };
        }
    }
}
