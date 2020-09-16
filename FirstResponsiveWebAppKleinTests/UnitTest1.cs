using System;
using Xunit;
using FirstResponsiveWebAppKlein.Models;

namespace FirstResponsiveWebAppKleinTests
{
    public class UnitTest1
    {
        [Fact]
        public void PassingCaseTest()
        {
            //Arrange
            string Name = "Kelly";
            var BirthYear = new DateTime(1979, 03, 21);
            string birthday = BirthYear.ToString();

            string expected = "Hello " + Name + ", your birthday is " + birthday + ".";
            string actual;

            //Act
            //Greeting greeting = new Greeting(Name, birthday);
            //actual = Greeting(Name, birthday);

            //Assert
        }
    }
}
