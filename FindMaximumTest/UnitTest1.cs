using Generic;

namespace FindMaximumTest
{
    public class Tests
    {
        FindMaximum findMaximum = new FindMaximum();

        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = findMaximum.FindMaxInt(20, 17, 10);
            Assert.AreEqual(20, result);
            Assert.Pass();
        }

        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = findMaximum.FindMaxInt(20, 30, 10);
            Assert.AreEqual(30, result);
            Assert.Pass();
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = findMaximum.FindMaxInt(20, 30, 50);
            Assert.AreEqual(50, result);
            Assert.Pass();
        }
        [Test]
        public void GivenMaxFirstFloatNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            float result = findMaximum.FindMaxFloat(36.21F, 12.36F, 25.45F);
            Assert.AreEqual(36.21F, result);
            Assert.Pass();
        }
    }
}
