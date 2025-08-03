using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02141Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02141();
        Assert.That(sut.MaxRunTime(2, [3, 3, 3]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02141();
        Assert.That(sut.MaxRunTime(2, [1, 1, 1, 1]), Is.EqualTo(2));
    }
}