using FizzBuzz;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public void When_FizzBuzzKalkyl_Message()
        {
            //Arrange
            StringWriter stringWriter = new StringWriter();
            
            Console.SetOut(stringWriter);
            
            var expected = "ABCDEFG";


            //Act
            Kalkylator.LogMessage(expected);
			var actuall = stringWriter.ToString().Trim();

			//Assert
			Assert.Equal(expected, actuall);
        }
                
        [Fact]
        public void When_FuzzBuzzKalkyl_String()
        {
            //Arrange
            Action act = () => Kalkylator.CheckIfNumber("k");

            //Act
            ArgumentException exception = Assert.Throws<ArgumentException>(act);

			//Assert
            Assert.Equal($"k is not a number", exception.Message);

		}
        
	}
}