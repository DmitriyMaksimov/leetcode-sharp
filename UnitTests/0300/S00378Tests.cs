using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00378Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00378();
        Assert.That(sut.KthSmallest([[1, 5, 9], [10, 11, 13], [12, 13, 15]], 8), Is.EqualTo(13));
    }

    [Test]
    public void T2()
    {
        var sut = new S00378();
        Assert.That(sut.KthSmallest([[-5]], 1), Is.EqualTo(-5));
    }
}
