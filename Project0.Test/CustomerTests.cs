using Project0.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Project0.Test
{
    public class CustomerTests
    {
        [Fact]
        public void NameShouldReturnFirstnameAndLastname()
        {
            // arrange
            string firstname = "John";
            string lastname = "Doe";
            string name = "John Doe";
            Customer c = new Customer(1, firstname, lastname);

            // act
            string actualName = c.Name;

            // assert
            Assert.Equal(name, actualName);
        }
    }
}
