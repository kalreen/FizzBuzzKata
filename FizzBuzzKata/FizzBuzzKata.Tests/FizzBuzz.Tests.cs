using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzzKata.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void FizzBuzz_GivenInteger1_ShouldReturnString1()
        {
            //--------------- Set up test pack --------------------
            var input = 1;
            var expected = "1";
            var systemUnderTest = new FizzBuzz();
            //--------------- Assert Precondition ----------------

            //---------------- Execute Test ----------------------
            var result = systemUnderTest.PrintFizzBuzz(input);
            // --------------- Test Result ------------------------
            Assert.AreEqual(expected,result);
        }
        
        [Test]
        public void FizzBuzz_GivenInteger2_ShouldReturnString2()
        {
            //--------------- Set up test pack --------------------
            var input = 2;
            var expected = "2";
            var systemUnderTest = new FizzBuzz();
            //--------------- Assert Precondition ----------------

            //---------------- Execute Test ----------------------
            var result = systemUnderTest.PrintFizzBuzz(input);
            // --------------- Test Result ------------------------
            Assert.AreEqual(expected,result);
        }

        
        [Test]
        public void FizzBuzz_GivenInteger3_ShouldReturnFizz()
        {
            //--------------- Set up test pack --------------------
            var input = 3;
            var expected = "Fizz";
            var systemUnderTest = new FizzBuzz();
            //--------------- Assert Precondition ----------------

            //---------------- Execute Test ----------------------
            var result = systemUnderTest.PrintFizzBuzz(input);
            // --------------- Test Result ------------------------
            Assert.AreEqual(expected,result);
        }


        [Test]
        public void FizzBuzz_GivenInteger4_ShouldReturn4String()
        {
            //--------------- Set up test pack --------------------
            var input = 4;
            var expected = "4";
            var systemUnderTest = new FizzBuzz();
            //--------------- Assert Precondition ----------------

            //---------------- Execute Test ----------------------
            var result = systemUnderTest.PrintFizzBuzz(input);
            // --------------- Test Result ------------------------
            Assert.AreEqual(expected,result);
        }

    }
}
