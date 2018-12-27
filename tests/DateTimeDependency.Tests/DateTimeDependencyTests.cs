using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace DateTimeDependency.Tests
{
    [TestClass]
    public class DateTimeDependencyTests
    {
        [TestMethod]
        public void GetDayOfWeek_Returns_Sunday()
        {
            // Arrange
            // 23-12-2018 was a Sunday.
            var datetime = new DateTime(2018, 12, 23);
            var mock = new Mock<IDateTime>();
            mock.Setup(d => d.Now).Returns(datetime);
            var mockDateTime = mock.Object;
            var expected = DayOfWeek.Sunday;
            var calendar = new Calendar(mockDateTime);

            // Act
            var actual = calendar.GetDayOfWeek();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDayOfWeek_Returns_Monday()
        {
            // Arrange
            // 24-12-2018 was a Monday.
            var datetime = new DateTime(2018, 12, 24);
            var mock = new Mock<IDateTime>();
            mock.Setup(d => d.Now).Returns(datetime);
            var mockDateTime = mock.Object;
            var expected = DayOfWeek.Monday;
            var calendar = new Calendar(mockDateTime);

            // Act
            var actual = calendar.GetDayOfWeek();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDayOfWeek_Returns_Tuesday()
        {
            // Arrange
            // 25-12-2018 was a Tuesday.
            var datetime = new DateTime(2018, 12, 25);
            var mock = new Mock<IDateTime>();
            mock.Setup(d => d.Now).Returns(datetime);
            var mockDateTime = mock.Object;
            var expected = DayOfWeek.Tuesday;
            var calendar = new Calendar(mockDateTime);

            // Act
            var actual = calendar.GetDayOfWeek();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDayOfWeek_Returns_Wednesday()
        {
            // Arrange
            // 26-12-2018 was a Wednesday.
            var datetime = new DateTime(2018, 12, 26);
            var mock = new Mock<IDateTime>();
            mock.Setup(d => d.Now).Returns(datetime);
            var mockDateTime = mock.Object;
            var expected = DayOfWeek.Wednesday;
            var calendar = new Calendar(mockDateTime);

            // Act
            var actual = calendar.GetDayOfWeek();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDayOfWeek_Returns_Thursday()
        {
            // Arrange
            // 27-12-2018 was a Thursday.
            var datetime = new DateTime(2018, 12, 27);
            var mock = new Mock<IDateTime>();
            mock.Setup(d => d.Now).Returns(datetime);
            var mockDateTime = mock.Object;
            var expected = DayOfWeek.Thursday;
            var calendar = new Calendar(mockDateTime);

            // Act
            var actual = calendar.GetDayOfWeek();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDayOfWeek_Returns_Friday()
        {
            // Arrange
            // 28-12-2018 was a Friday.
            var datetime = new DateTime(2018, 12, 28);
            var mock = new Mock<IDateTime>();
            mock.Setup(d => d.Now).Returns(datetime);
            var mockDateTime = mock.Object;
            var expected = DayOfWeek.Friday;
            var calendar = new Calendar(mockDateTime);

            // Act
            var actual = calendar.GetDayOfWeek();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDayOfWeek_Returns_Saturday()
        {
            // Arrange
            // 29-12-2018 was a Saturday.
            var datetime = new DateTime(2018, 12, 29);
            var mock = new Mock<IDateTime>();
            mock.Setup(d => d.Now).Returns(datetime);
            var mockDateTime = mock.Object;
            var expected = DayOfWeek.Saturday;
            var calendar = new Calendar(mockDateTime);

            // Act
            var actual = calendar.GetDayOfWeek();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
