using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01006Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01006();
        Assert.That(sut.Clumsy(4), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S01006();
        Assert.That(sut.Clumsy(10), Is.EqualTo(12));
    }
}
