using Common.Manipulations;

namespace ManipulateLinesTest
{
    public class TestingEx1
    {
        private readonly string[] inputLines = new[]
            {
                "Apple",
                "Pear",
                "Banana",
                "Monkeys love bananas",
                "I liked the movie “The Matrix”",
                "007: Goldfinger",
                "She sells seashells by the seashore"
            };

        [Fact]
        public void CalculateLineLengthsFunction()
        {
            // Arrange
            var calculateLineLengths = new CalculateLineLengths();


            string[] expectedLines = new[]
            {
                "5 Apple",
                "4 Pear",
                "6 Banana",
                "20 Monkeys love bananas",
                "30 I liked the movie “The Matrix”",
                "15 007: Goldfinger",
                "35 She sells seashells by the seashore"
            };

            // Act
            var result = calculateLineLengths.Manipulate(inputLines);

            // Assert
            Assert.Equal(expectedLines.Length, result.Length);
            for (int i = 0; i < expectedLines.Length; i++)
            {
                Assert.Equal(expectedLines[i], result[i]);
            }

        }

        [Fact]
        public void SortsLinesAlphabeticallyFunction()
        {
            // Arrange
            var sorter = new SortLines();

            string[] expectedLines = new[]
            {
                "007: Goldfinger",
                "Apple",
                "Banana",
                "I liked the movie “The Matrix”",
                "Monkeys love bananas",
                "Pear",
                "She sells seashells by the seashore"
            };

            // Act
            var result = sorter.Manipulate(inputLines);

            // Assert
            Assert.Equal(expectedLines.Length, result.Length);
            for (int i = 0; i < expectedLines.Length; i++)
            {
                Assert.Equal(expectedLines[i], result[i]);
            }
        }

        [Fact]
        public void ReversedLinesFunction()
        {
            // Arrange
            var sorter = new ReverseLines();

            string[] expectedLines = new[]
            {
                "She sells seashells by the seashore",
                "007: Goldfinger",
                "I liked the movie “The Matrix”",
                "Monkeys love bananas",
                "Banana",
                "Pear",
                "Apple"
            };

            // Act
            var result = sorter.Manipulate(inputLines);

            // Assert
            Assert.Equal(expectedLines.Length, result.Length);
            for (int i = 0; i < expectedLines.Length; i++)
            {
                Assert.Equal(expectedLines[i], result[i]);
            }
        }


        [Fact]
        public void Manipulate_EncryptsLinesCorrectly()
        {
            // Arrange
            var encrypter = new EncryptLines();

            string[] expectedLines = new[]
            {
                "U\u0084\u0084\u0080y",
                "dyu\u0086",
                "Vu\u0082u\u0082u",
                "a\u0083\u0082\u007fy\u008d\u00874\u0080\u0083\u008ay4vu\u0082u\u0082u\u0087",
                "]4\u0080}\u007fyx4\u0088|y4\u0081\u0083\u008a}y4‰h|y4au\u0088\u0086}\u008c‱",
                "DDKN4[\u0083\u0080xz}\u0082{y\u0086",
                "g|y4\u0087y\u0080\u0080\u00874\u0087yu\u0087|y\u0080\u0080\u00874v\u008d4\u0088|y4\u0087yu\u0087|\u0083\u0086y"
            };



            // Act
            var result = encrypter.Manipulate(inputLines);

            // Assert
            Assert.Equal(expectedLines.Length, result.Length);
            for (int i = 0; i < expectedLines.Length; i++)
            {
                Assert.Equal(expectedLines[i], result[i]);
            }
        }
    }
}