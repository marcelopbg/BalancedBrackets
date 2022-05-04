using NUnit.Framework;

namespace BalancedBracketsTest
{
    public class BalancedBracketsTest
    {
        [Test]
        public void TestIfCodePassExampleResults()
        {
            var test1 = BalancedBrackets.AreBracketsBalanced("(){}[]");
            var test2 = BalancedBrackets.AreBracketsBalanced("[{()}](){}");
            var test3 = BalancedBrackets.AreBracketsBalanced("[]{()");
            var test4 = BalancedBrackets.AreBracketsBalanced("[{)]");
            Assert.AreEqual(test1, true);
            Assert.AreEqual(test2, true);
            Assert.AreEqual(test3, false);
            Assert.AreEqual(test4, false);
        }
    }
}