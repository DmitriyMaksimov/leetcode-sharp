using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00374Tests
{
    [TestCase(10, 6)]
    [TestCase(1, 1)]
    [TestCase(2, 1)]
    public void Test1(int n, int pick)
    {
        var sut = new S00374(pick.CompareTo);
        Assert.That(sut.GuessNumber(n), Is.EqualTo(pick));
    }    
}