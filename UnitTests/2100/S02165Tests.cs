using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02165Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02165();
        Assert.That(sut.SmallestNumber(310), Is.EqualTo(103));
    }

    [Test]
    public void T2()
    {
        var sut = new S02165();
        Assert.That(sut.SmallestNumber(-7605), Is.EqualTo(-7650));
    }
}
