using FizzBuzz;

namespace FizzBuzzTest
{
	public class UnitTest1
	{
		[Fact]
		public void When_FizzBuzzKalkyl_IsNotImplemented()
		{
            // Arrange
            int randomNummer = 0;

            // Act
            Kalkylator.FizzBuzzKalkyl(randomNummer);

            // Testet kommer att bli grönt då ett NotImplementedException kastas
            
        }
        [Fact]
        public void When_FizzBuzzKalkyl_Fizz()
        {
            //Arrange
            int number = 3;

            //Act
            var result = Kalkylator.FizzBuzzKalkyl(number);

            //Assert
            Assert.Equal("Fizz", result);
        }
        [Fact]
        public void When_FizzBuzzKalkyl_Buzz()
        {
            //Arrange
            int number = 5;

            //Act
            var result = Kalkylator.FizzBuzzKalkyl(number);

            //Assert
            Assert.Equal("Buzz", result.ToString());
        }
        [Fact]
        public void When_FizzBuzzKalkyl_FizzBuzz()
        {
            //Arrange
            int number = 15;

            //Act
            var result = Kalkylator.FizzBuzzKalkyl(number);

            //Assert
            Assert.Equal("FizzBuzz", result.ToString());
        }
        [Fact]
        public void When_FizzBuzzKalkyl_Number()
        {
            //Arrange
            int number = 2;

            //Act
            var result = Kalkylator.FizzBuzzKalkyl(number);
            //Assert
            Assert.Equal("2", result.ToString());
        }
        [Fact]
        public void When_FuzzBuzzKalkyl_String()
        {
            //Arrange
            string number = "5";
            //Act
            var result = Kalkylator.FizzBuzzKalkyl(number);
			//Assert
            Assert.Equal("");

		}
	}
}