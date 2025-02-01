using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02375Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02375();
        Assert.That(sut.SmallestNumber("IIIDIDDD"), Is.EqualTo("123549876"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02375();
        Assert.That(sut.SmallestNumber("DDD"), Is.EqualTo("4321"));
    }
}