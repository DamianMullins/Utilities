﻿using System.Utilities.Core.Text;
using NUnit.Framework;

namespace System.Utilities.Tests.Utilities.Core.Text
{
    [TestFixture]
    public class StringExtensionsTests
    {
        [Test]
        public void EmptyString_IsEmpty_ReturnsTrue()
        {
            // Arrange
            string emptyString = "";

            // Act
            bool isEmpty = emptyString.IsEmpty();

            // Assert
            Assert.IsTrue(isEmpty);
        }
        [Test]
        public void NullString_IsEmpty_ReturnsTrue()
        {
            // Arrange
            string nullString = null;

            // Act
            bool nullStringIsEmpty = nullString.IsEmpty();

            // Assert
            Assert.IsTrue(nullStringIsEmpty);
        }

        [Test]
        public void NonEmptyString_IsEmpty_ReturnsFalse()
        {
            // Arrange
            string nonEmptyString = "Test String";

            // Act
            bool isNotEmpty = nonEmptyString.IsEmpty();

            // Assert
            Assert.IsFalse(isNotEmpty);
        }

        [Test]
        public void EmptyString_IsNotEmpty_ReturnsFalse()
        {
            // Arrange
            string emptyString = "";

            // Act
            bool isEmpty = emptyString.IsNotEmpty();

            // Assert
            Assert.IsFalse(isEmpty);
        }

        [Test]
        public void NonEmptyString_IsNotEmpty_ReturnsTrue()
        {
            // Arrange
            string nonEmptyString = "Test String";

            // Act
            bool isNotEmpty = nonEmptyString.IsNotEmpty();

            // Assert
            Assert.IsTrue(isNotEmpty);
        }

        [Test]
        public void EmptyString_IsNotEmptyAndEqualTo_ReturnsFalse()
        {
            // Arrange
            string emptyString = "";

            // Act
            bool isEmpty = emptyString.IsNotEmptyAndEqualTo("Test String");
            bool isEmptyWithNoEqualValue = emptyString.IsNotEmptyAndEqualTo("");
            bool isEmptyWithNullEqualValue = emptyString.IsNotEmptyAndEqualTo(null);

            // Assert
            Assert.IsFalse(isEmpty);
            Assert.IsFalse(isEmptyWithNoEqualValue);
            Assert.IsFalse(isEmptyWithNullEqualValue);
        }

        [Test]
        public void NonEmptyString_IsNotEmptyAndEqualTo_ReturnsTrue()
        {
            // Arrange
            string nonEmptyString = "Test String";

            // Act
            bool isNotEmpty = nonEmptyString.IsNotEmptyAndEqualTo("Test String");

            // Assert
            Assert.IsTrue(isNotEmpty);
        }

        [Test]
        public void EmptyString_IsNotEmptyOrEqualTo_ReturnsFalse()
        {
            // Arrange
            string emptyString = "";

            // Act
            bool isEmpty = emptyString.IsNotEmptyOrEqualTo("Test String");
            bool isEmptyWithNoEqualValue = emptyString.IsNotEmptyOrEqualTo("");
            bool isEmptyWithNullEqualValue = emptyString.IsNotEmptyOrEqualTo(null);

            // Assert
            Assert.IsFalse(isEmpty);
            Assert.IsFalse(isEmptyWithNoEqualValue);
            Assert.IsFalse(isEmptyWithNullEqualValue);
        }

        [Test]
        public void NonEmptyString_IsNotEmptyOrEqualTo_ReturnsTrue()
        {
            // Arrange
            string nonEmptyString = "Test String";

            // Act
            bool isNotEmptyWithMatchingValue = nonEmptyString.IsNotEmptyOrEqualTo("Test String");
            bool isNotEmptyWithNonMatchingValue = nonEmptyString.IsNotEmptyOrEqualTo("Non Matching Test String");

            // Assert
            Assert.IsFalse(isNotEmptyWithMatchingValue);
            Assert.IsTrue(isNotEmptyWithNonMatchingValue);
        }

        [Test]
        public void EmptyString_Truncate_ReturnsEmptyString()
        {
            // Arrange
            string emptyString = "";

            // Act
            string truncated = emptyString.Truncate();

            // Assert
            Assert.AreEqual(string.Empty, truncated);
        }

        [Test]
        public void NullString_Truncate_ReturnsEmptyString()
        {
            // Arrange
            string emptyString = null;

            // Act
            string truncated = emptyString.Truncate();

            // Assert
            Assert.AreEqual(string.Empty, truncated);
        }

        [Test]
        public void NonEmptyString_Truncate_ReturnsEmptyString()
        {
            // Arrange
            string stringToTruncate = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean luctus, massa quis mattis mollis, ligula tellus sollicitudin neque, ut pretium risus neque vitae diam.";

            // Act
            string truncated = stringToTruncate.Truncate();

            // Assert
            Assert.AreEqual("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean luctus, mas ...", truncated);
            Assert.AreEqual(79, truncated.Length);
        }

        [Test]
        public void NonEmptyString_TruncateWithLength_ReturnsEmptyString()
        {
            // Arrange
            string stringToTruncate = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean luctus, massa quis mattis mollis, ligula tellus sollicitudin neque, ut pretium risus neque vitae diam.";

            // Act
            string truncated = stringToTruncate.Truncate(100);

            // Assert
            Assert.AreEqual("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean luctus, massa quis mattis mollis, li ...", truncated);
            Assert.AreEqual(104, truncated.Length);
        }
    }
}
