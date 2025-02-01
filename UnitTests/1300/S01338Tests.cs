using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01338Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01338();
        Assert.That(sut.MinSetSize([3, 3, 3, 3, 5, 5, 5, 2, 2, 7]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01338();
        Assert.That(sut.MinSetSize([7, 7, 7, 7, 7, 7]), Is.EqualTo(1));
    }
}
