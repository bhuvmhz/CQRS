using Documents.CarDocuments;
using Shouldly;
using Xunit;

namespace DomainTests
{
    public class CarValidationUnitTests
    {
        [Fact]
        public void ValidateCar()
        {
            var cv = new CarValidator();
            var result = cv.Validate(new Car() { PlateNo = "LYE801" });
            result.IsValid.ShouldBe(true);
        }
    }
}
