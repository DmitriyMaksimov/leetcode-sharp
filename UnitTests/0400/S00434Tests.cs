using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00434Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00434();
        Assert.That(sut.CountSegments("Hello, my name is John"), Is.EqualTo(5));
    }

    [Test]
    public void T3()
    {
        var sut = new S00434();
        Assert.That(sut.CountSegments("Hello"), Is.EqualTo(1));
    }
}