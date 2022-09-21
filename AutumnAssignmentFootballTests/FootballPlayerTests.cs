using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutumnAssignmentFootball;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutumnAssignmentFootball.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        [TestMethod()]
        public void AgeValidationTest()
        {
            FootballPlayer agevalidation = new FootballPlayer(1, "Jensen", 1, 20);
            FootballPlayer invalidagevalidation = new FootballPlayer(2, "hansen", 0, 20);


            Assert.ThrowsException<ArgumentOutOfRangeException>(invalidagevalidation.AgeValidation);
        }

        [TestMethod()]
        public void NameValidatorTest()
        {
            FootballPlayer namevalid = new FootballPlayer(1, "Jensen", 1, 20);
            FootballPlayer nameinvalid = new FootballPlayer(1, null, 1, 20);

            Assert.ThrowsException<ArgumentNullException>(nameinvalid.NameValidator);

        }

        [TestMethod()]
        public void ShirtNumberValidationTest()
        {
            FootballPlayer shirtnumbervalid = new FootballPlayer(1, "Jensen", 1, 99);
            FootballPlayer shirtnumberinvalid100 = new FootballPlayer(1, "Jensen", 1, 100);
            FootballPlayer shirtnumberinvalid0 = new FootballPlayer(1, "Jensen", 1, 0);

            Assert.ThrowsException<ArgumentOutOfRangeException>(shirtnumberinvalid100.ShirtNumberValidation);
            Assert.ThrowsException<ArgumentOutOfRangeException>(shirtnumberinvalid0.ShirtNumberValidation);
        }
    }
}