using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02383Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02383();
        Assert.That(sut.MinNumberOfHours(5, 3, [1, 4, 3, 2], [2, 6, 3, 1]), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S02383();
        Assert.That(sut.MinNumberOfHours(2, 4, [1], [3]), Is.EqualTo(0));
    }
}