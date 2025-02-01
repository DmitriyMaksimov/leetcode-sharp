using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01954Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01954();
        Assert.That(sut.MinimumPerimeter(1), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S01954();
        Assert.That(sut.MinimumPerimeter(13), Is.EqualTo(16));
    }

    [Test]
    public void T3()
    {
        var sut = new S01954();
        Assert.That(sut.MinimumPerimeter(1000000000), Is.EqualTo(5040));
    }
}
