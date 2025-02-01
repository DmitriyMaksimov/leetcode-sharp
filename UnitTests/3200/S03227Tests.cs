using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03227Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03227();
        Assert.That(sut.DoesAliceWin("leetcoder"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03227();
        Assert.That(sut.DoesAliceWin("bbcd"), Is.False);
    }
}
