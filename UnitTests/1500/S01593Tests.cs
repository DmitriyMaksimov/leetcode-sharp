using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01593Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01593();
        Assert.That(sut.MaxUniqueSplit("ababccc"), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S01593();
        Assert.That(sut.MaxUniqueSplit("aba"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01593();
        Assert.That(sut.MaxUniqueSplit("aa"), Is.EqualTo(1));
    }
}
