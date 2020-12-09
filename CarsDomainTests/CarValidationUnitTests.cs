using Documents.CarDocuments;
using Shouldly;
using Xunit;

namespace Shared
{
    public class CarValidationUnitTests
    {
        [Theory]
        [CsvData(@"TestData.csv")]
        public void Test(string plateNo, bool isValid)
        {
            var car = new Car() { PlateNo = plateNo };
            var carValidator = new CarValidator();
            var validationResults = carValidator.Validate(car);
            validationResults.IsValid.ShouldBe(isValid);
        }
    }
}
