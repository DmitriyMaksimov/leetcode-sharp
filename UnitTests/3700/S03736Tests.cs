using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03736))]
public class S03736Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03736();
        Assert.That(sut.MinMoves([2, 1, 3]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03736();
        Assert.That(sut.MinMoves([4, 4, 5]), Is.EqualTo(2));
    }
}