using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00495Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00495();
        Assert.That(sut.FindPoisonedDuration(new[] {1, 4}, 2), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00495();
        Assert.That(sut.FindPoisonedDuration(new[] {1, 2}, 2), Is.EqualTo(3));
    }
}