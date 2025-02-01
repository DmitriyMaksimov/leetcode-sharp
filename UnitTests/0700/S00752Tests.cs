using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00752Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00752();
        Assert.That(sut.OpenLock(["0201", "0101", "0102", "1212", "2002"], "0202"), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S00752();
        Assert.That(sut.OpenLock(["8888"], "0009"), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S00752();
        Assert.That(sut.OpenLock(["8887", "8889", "8878", "8898", "8788", "8988", "7888", "9888"], "8888"), Is.EqualTo(-1));
    }
}