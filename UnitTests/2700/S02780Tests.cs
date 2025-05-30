using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02780Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02780();
        Assert.That(sut.MinimumIndex([1, 2, 2, 2]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02780();
        Assert.That(sut.MinimumIndex([2, 1, 3, 1, 1, 1, 7, 1, 2, 1]), Is.EqualTo(4));
    }
}
