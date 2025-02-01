using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03360Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03360();
        Assert.That(sut.CanAliceWin(12), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03360();
        Assert.That(sut.CanAliceWin(1), Is.False);
    }
}
