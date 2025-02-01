using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02729Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02729();
        Assert.That(sut.IsFascinating(192), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02729();
        Assert.That(sut.IsFascinating(100), Is.False);
    }
}
