using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00455Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00455();
        Assert.That(sut.FindContentChildren([1, 2, 3], [1, 1]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00455();
        Assert.That(sut.FindContentChildren([1, 2], [1, 2, 3]), Is.EqualTo(2));
    }
}