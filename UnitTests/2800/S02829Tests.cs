using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02829Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02829();
        Assert.That(sut.MinimumSum(5, 4), Is.EqualTo(18));
    }

    [Test]
    public void T2()
    {
        var sut = new S02829();
        Assert.That(sut.MinimumSum(2, 6), Is.EqualTo(3));
    }
}
