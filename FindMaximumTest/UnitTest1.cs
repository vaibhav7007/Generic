using Generic;

namespace FindMaximumTest
{
    public class Tests
    {
        FindMaximum findMaximum = new FindMaximum();

        [Test]      //TC-1.1
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = findMaximum.FindMaxInt(20, 17, 10);
            Assert.AreEqual(20, result);
            Assert.Pass();
        }

        [Test]      //TC-1.2
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = findMaximum.FindMaxInt(20, 30, 10);
            Assert.AreEqual(30, result);
            Assert.Pass();
        }
        [Test]      //TC-1.3
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = findMaximum.FindMaxInt(20, 30, 50);
            Assert.AreEqual(50, result);
            Assert.Pass();
        }
        [Test]      //TC-2.1
        public void GivenMaxFirstFloatNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            float result = findMaximum.FindMaxFloat(36.21F, 12.36F, 25.45F);
            Assert.AreEqual(36.21F, result);
            Assert.Pass();
        }
        [Test]      //TC-2.2
        public void GivenMaxSecondFloatNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            float result = findMaximum.FindMaxFloat(36.21F, 45.36F, 25.45F);
            Assert.AreEqual(45.36F, result);
            Assert.Pass();
        }
        [Test]      //TC-2.3
        public void GivenMaxThirdFloatNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            float result = findMaximum.FindMaxFloat(36.21F, 45.36F, 56.45F);
            Assert.AreEqual(56.45F, result);
            Assert.Pass();
        }
        [Test]      //TC-3.1
        public void GivenMaxFirstString_WhenAnalysed_ShouldReturnFirstStringMax()
        {
            string result = findMaximum.FindMaxString("Apple", "Banana", "Pear"); ;
            Assert.AreEqual("Pear", result);
            Assert.Pass();
        }
        [Test]      //TC-3.2
        public void GivenMaxSecondString_WhenAnalysed_ShouldReturnSecondStringMax()
        {
            string result = findMaximum.FindMaxString("Apple", "Pear", "Banana"); ;
            Assert.AreEqual("Pear", result);
            Assert.Pass();
        }
    }
}
