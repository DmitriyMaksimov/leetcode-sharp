using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03340Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03340();
        Assert.That(sut.IsBalanced("1234"), Is.False);
    }

    [Test]
    public void T2()
    {
        var sut = new S03340();
        Assert.That(sut.IsBalanced("24123"), Is.True);
    }
}
