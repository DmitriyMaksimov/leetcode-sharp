using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00764))]
public class S00764Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00764();
        Assert.That(sut.OrderOfLargestPlusSign(5, [[4, 2]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00764();
        Assert.That(sut.OrderOfLargestPlusSign(1, [[0, 0]]), Is.EqualTo(0));
    }
}
