using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02567))]
public class S02567Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02567();
        Assert.That(sut.MinimizeSum([1, 4, 7, 8, 5]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02567();
        Assert.That(sut.MinimizeSum([1, 4, 3]), Is.EqualTo(0));
    }
}
