using ClassLibArray;
using System.Runtime.Intrinsics.Arm;

namespace ArrayGen.Tests
{
    public class ArrayMakerTests
    {
        [Fact]
        public void Check_SumMoreThenZero()
        {
            // Arrange
            int[] expectedArray = ArrayGenerator.Array();

            // Act
            int actual = ArrayGenerator.Summing(expectedArray);

            // Assert
            Assert.True(actual > 0);
        }

        [Fact]
        public void Check_SumLessThenZero()
        {
            int[] expectedArray = ArrayGenerator.Array();

            int actual = ArrayGenerator.Summing(expectedArray);

            Assert.True(actual < 0);
        }

        [Fact]
        public void Check_ArrayWithPositiveNum()
        {
            int[] expectedArray = ArrayGenerator.Array();

            int actual = ArrayGenerator.Counting(expectedArray);

            Assert.True(actual > 0);
        }

        [Fact]
        public void Check_ArrayWithoutPositiveNum()
        {
            int[] expectedArray = ArrayGenerator.Array();

            int actual = ArrayGenerator.Counting(expectedArray);

            Assert.Equal(0, actual);
        }

    }
}