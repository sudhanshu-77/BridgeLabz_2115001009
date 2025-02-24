using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringUtilsApp;
using NUnit.Framework;
using NUnit;

namespace StringUtilsTest
{
    [TestFixture]
    public class StringUtilsTests
    {
        private StringUtils _stringUtils;

        [SetUp]
        public void Setup()
        {
            _stringUtils = new StringUtils();
        }

        [Test]
        public void Reverse_ShouldReturnReversedString()
        {
            string input = "hello";
            string expected = "olleh";
            string result = _stringUtils.Reverse(input);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsPalindrome_ShouldReturnTrueForPalindrome()
        {
            bool result = _stringUtils.IsPalindrome("madam");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_ShouldReturnFalseForNonPalindrome()
        {
            bool result = _stringUtils.IsPalindrome("hello");
            Assert.IsFalse(result);
        }

        [Test]
        public void ToUpperCase_ShouldConvertStringToUpperCase()
        {
            string result = _stringUtils.ToUpperCase("hello");
            Assert.That("HELLO", Is.EqualTo(result));


        }

        [Test]
        public void Reverse_NullString_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _stringUtils.Reverse(null));
        }

        [Test]
        public void IsPalindrome_NullString_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _stringUtils.IsPalindrome(null));
        }

        [Test]
        public void ToUpperCase_NullString_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _stringUtils.ToUpperCase(null));
        }
    }
}


