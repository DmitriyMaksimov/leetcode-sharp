using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01399Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01399();
        Assert.That(sut.CountLargestGroup(13), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01399();
        Assert.That(sut.CountLargestGroup(2), Is.EqualTo(2));
    }
}