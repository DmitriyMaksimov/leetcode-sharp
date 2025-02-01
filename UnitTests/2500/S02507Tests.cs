using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02507Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02507();
        Assert.That(sut.SmallestValue(15), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S02507();
        Assert.That(sut.SmallestValue(3), Is.EqualTo(3));
    }
}