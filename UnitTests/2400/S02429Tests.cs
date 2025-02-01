using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02429Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02429();
        Assert.That(sut.MinimizeXor(3, 5), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02429();
        Assert.That(sut.MinimizeXor(1, 12), Is.EqualTo(3));
    }
}
