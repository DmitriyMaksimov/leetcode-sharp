using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02779Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02779();
        Assert.That(sut.MaximumBeauty([4, 6, 1, 2], 2), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02779();
        Assert.That(sut.MaximumBeauty([1, 1, 1, 1], 10), Is.EqualTo(4));
    }
}
