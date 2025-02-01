using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02593Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02593();
        Assert.That(sut.FindScore([2, 1, 3, 4, 5, 2]), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S02593();
        Assert.That(sut.FindScore([2, 3, 5, 1, 3, 2]), Is.EqualTo(5));
    }
}
