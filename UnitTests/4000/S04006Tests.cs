using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S04006))]
public class S04006Tests
{
    [Test]
    public void T1()
    {
        var sut = new S04006();
        Assert.That(sut.CountValidPrefixes("00101"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S04006();
        Assert.That(sut.CountValidPrefixes("101"), Is.EqualTo(3));
    }
}