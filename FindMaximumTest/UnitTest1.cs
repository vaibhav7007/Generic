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
    }
}