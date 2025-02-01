using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01415Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01415();
        Assert.That(sut.GetHappyString(1, 3), Is.EqualTo("c"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01415();
        Assert.That(sut.GetHappyString(1, 4), Is.EqualTo(""));
    }

    [Test]
    public void T3()
    {
        var sut = new S01415();
        Assert.That(sut.GetHappyString(3, 9), Is.EqualTo("cab"));
    }
}